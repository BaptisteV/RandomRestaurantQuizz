using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Photos;
using System.Net.Http.Json;

namespace RandomRestaurantQuizz.Core.Places;

public sealed class GooglePlacesClient : IGooglePlacesClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly IPhotoDownloader _photoDownloader;
    private readonly ILogger<GooglePlacesClient> _logger;

    public GooglePlacesClient(HttpClient httpClient, IOptionsMonitor<SecretsJson> config, IPhotoDownloader photoDownloader, ILogger<GooglePlacesClient> logger)
    {
        _httpClient = httpClient;
        _photoDownloader = photoDownloader;
        _logger = logger;
        var sec = config.CurrentValue;
        _apiKey = sec.GooglePlacesApiKey;
    }

    public async Task<List<PlaceResult>> GetRestaurantsInCity(GeoLoc center, int radiusSize = 1000, CancellationToken cancellationToken = default)
    {
        var request = new
        {
            locationRestriction = new
            {
                circle = new
                {
                    center = new
                    {
                        latitude = center.Latitude,
                        longitude = center.Longitude,
                    },
                    // Max 50000
                    radius = radiusSize,
                },
            },
            includedTypes = new[] { "restaurant" },
        };

        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
        {
            Content = JsonContent.Create(request),
        };

        httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
        httpRequest.Headers.Add("X-Goog-FieldMask", "places.displayName,places.rating,places.userRatingCount,places.photos,places.formattedAddress");

        var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadFromJsonAsync<PlacesApiResponse>(cancellationToken: cancellationToken);

        return json?.Places ?? [];
    }

    public async Task<List<PlaceResult>> GetRestaurants(GeoLoc center, CancellationToken cancellationToken = default)
    {
        // Get all possible restaurants
        var restaurants = (await GetRestaurantsInCity(center, 1000, cancellationToken)).Where(r => r.Photos?.Count > 0).ToList();

        // Enrich with photos
        var restaurantsWithFirstPhoto = await _photoDownloader.GetPhotos(restaurants, cancellationToken);

        // Filter only those with at least one photo and more than 1 user rating
        var selectedRestaurants = restaurantsWithFirstPhoto.Where(r => r.UserRatingCount > 0).ToList();
        _logger.LogInformation("Selected {SelectedRestaurantCount} out of {RestaurantCount}", selectedRestaurants.Count, restaurants.Count);

        return selectedRestaurants;
    }
}



using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace RandomRestaurantQuizz;

public sealed class GooglePlacesClient
{
    private const string BaseUrl = "https://places.googleapis.com/v1/places:searchNearby";
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly ILogger<GooglePlacesClient> _logger;

    public GooglePlacesClient(HttpClient httpClient, string apiKey, ILogger<GooglePlacesClient> logger)
    {
        _httpClient = httpClient;
        _apiKey = apiKey;
        _logger = logger;
    }

    public async Task<IList<PlaceResult>> GetRestaurantsInCity(GeoLoc center, int radiusSize = 1000, CancellationToken cancellationToken = default)
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

        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, BaseUrl)
        {
            Content = JsonContent.Create(request),
        };

        httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
        httpRequest.Headers.Add("X-Goog-FieldMask", "places.displayName,places.rating,places.userRatingCount,places.photos,places.formattedAddress");

        // var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        // response.EnsureSuccessStatusCode();
        // var json = await response.Content.ReadFromJsonAsync<PlacesApiResponse>(cancellationToken: cancellationToken);

        var json = JsonSerializer.Deserialize<PlacesApiResponse>(TestData.JsonDij, new JsonSerializerOptions(JsonSerializerDefaults.Web));

        return json?.Places ?? [];
    }
}

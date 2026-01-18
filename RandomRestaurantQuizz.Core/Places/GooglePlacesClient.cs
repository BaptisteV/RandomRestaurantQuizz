using Microsoft.Extensions.Options;
using RandomRestaurantQuizz.Core.Models;
using System.Net.Http.Json;

namespace RandomRestaurantQuizz.Core.Places;

public sealed class GooglePlacesClient : IGooglePlacesClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public GooglePlacesClient(HttpClient httpClient, IOptionsMonitor<SecretsJson> config)
    {
        _httpClient = httpClient;
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
}

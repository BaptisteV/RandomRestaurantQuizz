

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

    public async Task<IList<PlaceResult>> GetRestaurantsInDijonAsync(
    CancellationToken cancellationToken = default)
    {
        var request = new
        {
            locationRestriction = new
            {
                circle = new
                {
                    center = new
                    {
                        latitude = 47.3220,
                        longitude = 5.0415
                    },
                    radius = 100
                }
            },
            includedTypes = new[] { "restaurant" }
        };

        using var httpRequest = new HttpRequestMessage(
            HttpMethod.Post,
            BaseUrl)
        {
            Content = JsonContent.Create(request)
        };

        httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
        httpRequest.Headers.Add(
            "X-Goog-FieldMask",
            "places.displayName,places.rating,places.userRatingCount,places.photos,places.formattedAddress");

        //var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        //response.EnsureSuccessStatusCode();
        //var jsonToSave = await response.Content.ReadAsStringAsync(cancellationToken);
        //var json = await response.Content.ReadFromJsonAsync<PlacesApiResponse>(TestData.JsonDij,
        //    cancellationToken: cancellationToken);

        var json = JsonSerializer.Deserialize<PlacesApiResponse>(TestData.JsonDij, new JsonSerializerOptions(JsonSerializerDefaults.Web));

        return json?.Places ?? [];
    }


}

using RandomRestaurantQuizz.Core.Places.Api;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public class RestauQuizzClient : IGooglePlacesClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<RestauQuizzClient> _logger;
    private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public RestauQuizzClient(HttpClient client, ILogger<RestauQuizzClient> logger)
    {
        _httpClient = client;
        _logger = logger;
        _httpClient.BaseAddress = new Uri("https://restauquizz.fly.dev/");
    }

    public async Task<List<PlaceResult>> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        var getRestaurants = new Uri($"/restaurants/{searchLocation.Name}", UriKind.Relative);

        var httpResponse = await _httpClient.GetAsync(getRestaurants);
        var jsonContent = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
        var response = JsonSerializer.Deserialize<PlacesApiResponse?>(jsonContent, _jsonOptions);

        if (response is null)
        {
            _logger.LogError("Error deserializing json : {Json}", jsonContent);
            return [];
        }

        if (response.Places?.Count == 0)
            _logger.LogError("No restaurants found in the area centered at ({Lat},{Lng}) with radius {Radius}", searchLocation.Latitude, searchLocation.Longitude, searchLocation.Name);

        return response.Places ?? [];
    }
}

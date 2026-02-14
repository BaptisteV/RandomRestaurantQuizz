using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places.Api;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public class RestauQuizzClient : IInternalPlacesClient
{
    private readonly HttpClient _httpClient;
    private readonly IPhotoDownloader _photoDownloader;
    private readonly ILogger<RestauQuizzClient> _logger;
    private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public RestauQuizzClient(HttpClient client, IPhotoDownloader photoDownloader, ILogger<RestauQuizzClient> logger)
    {
        _httpClient = client;
        _photoDownloader = photoDownloader;
        _logger = logger;
        _httpClient.BaseAddress = new Uri("https://restauquizz.fly.dev/");
    }

    public async Task<PlacesApiResponse> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken)
    {
        var getRestaurants = new Uri($"/restaurants/{searchParams.Location.Name}?lang={searchParams.Language}", UriKind.Relative);

        var httpResponse = await _httpClient.GetAsync(getRestaurants, cancellationToken);
        if (!httpResponse.IsSuccessStatusCode)
        {
            var content = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
            _logger.LogError("Error {HttpCode} calling the Google Places API. Response content: {ResponseContent}", httpResponse.StatusCode, content);
            return new();
        }

        var jsonContent = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
        var response = JsonSerializer.Deserialize<PlacesApiResponse?>(jsonContent, _jsonOptions);

        if (response is null)
        {
            _logger.LogError("Error deserializing json : {Json}", jsonContent);
            return new();
        }

        if (response.Places.Count == 0)
            _logger.LogError("No restaurants found in the area centered at ({Lat},{Lng}) with radius {Radius}", searchParams.Location.Latitude, searchParams.Location.Longitude, searchParams.Location.Name);

        // Enrich with photos
        var withPhotos = new PlacesApiResponse()
        {
            Places = await _photoDownloader.GetPhotos(response.Places!, cancellationToken)
        };
        return withPhotos;
    }
}

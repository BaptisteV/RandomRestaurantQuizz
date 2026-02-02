using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
using System.Net.Http.Json;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public sealed class GooglePlacesClient : IGooglePlacesClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

    private readonly IPhotoDownloader _photoDownloader;

    private readonly ILogger<GooglePlacesClient> _logger;

    private GeoLoc _center = new();
    private int _radius = 1_000;

    public GooglePlacesClient(HttpClient httpClient, IOptionsMonitor<SecretsJson> config, IPhotoDownloader photoDownloader, ILogger<GooglePlacesClient> logger)
    {
        _httpClient = httpClient;
        _photoDownloader = photoDownloader;
        _logger = logger;
        _apiKey = config.CurrentValue.GooglePlacesApiKey;
    }

    private static NearbySearchRequest CreateRequest(GeoLoc center, int radiusSize)
    {
        return new NearbySearchRequest
        {
            LocationRestriction = new LocationRestriction
            {
                Circle = new Circle
                {
                    Center = center,
                    Radius = radiusSize,
                }
            },
            IncludedTypes = ["restaurant"]
        };
    }

    private async Task<List<PlaceResult>> RestaurantsAround(CancellationToken cancellationToken)
    {
        var request = CreateRequest(_center, _radius);

        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
        {
            Content = JsonContent.Create(request),
        };

        httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
        httpRequest.Headers.Add("X-Goog-FieldMask", "places.displayName,places.rating,places.userRatingCount,places.photos,places.formattedAddress,places.reviews");

        var httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken);
        httpResponse.EnsureSuccessStatusCode();

        var jsonContent = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
        var response = JsonSerializer.Deserialize<PlacesApiResponse?>(jsonContent, _jsonOptions);

        if (response is null)
        {
            _logger.LogError("Error deserializing json : {Json}", jsonContent);
            return [];
        }

        if (response.Places?.Count == 0)
            _logger.LogWarning("No restaurants found in the area centered at ({Lat},{Lng}) with radius {Radius}m", _center.Latitude, _center.Longitude, _radius);

        return response.Places ?? [];
    }

    public async Task<List<PlaceResult>> GetRestaurants(CancellationToken cancellationToken)
    {
        // Get all possible restaurants
        var restaurantsInCity = (await RestaurantsAround(cancellationToken)).ToList();

        // Remove restaurants with no photo to download or no rating
        var restaurants = restaurantsInCity.WithRatingAndPhotos();

        var filteredCount = restaurantsInCity.Count - restaurants.Count;
        if (filteredCount > 0)
        {
            _logger.LogInformation("Deleted {NoRatingCount} restaurants as they don't have a single user rating or no photo", filteredCount);
        }
        _logger.LogInformation("Downloading all photos for {RestauCount} restaurants", restaurants.Count);

        // Enrich with photos
        return await _photoDownloader.GetPhotos(restaurants, cancellationToken);
    }

    public void SetSearchLocation(GeoLoc location, int radius)
    {
        _center = location;
        _radius = radius;
    }
}

using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places.Api;
using System.Globalization;
using System.Net.Http.Json;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public sealed class GooglePlacesClient : IGooglePlacesClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    private readonly IPhotoDownloader _photoDownloader;

    private readonly ILogger<GooglePlacesClient> _logger;

    public GooglePlacesClient(HttpClient httpClient, SecretsJson config, IPhotoDownloader photoDownloader, ILogger<GooglePlacesClient> logger)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://places.googleapis.com/v1/places:searchNearby");
        _photoDownloader = photoDownloader;
        _logger = logger;
        _apiKey = config.GooglePlacesApiKey;
    }

    private static NearbySearchRequest CreateRequest(SearchLocation center)
    {
        return new NearbySearchRequest
        {
            LocationRestriction = new LocationRestriction
            {
                Circle = new Circle
                {
                    Center = new Center() { Latitude = center.Latitude, Longitude = center.Longitude },
                    Radius = SearchLocation.SearchRadius,
                }
            },
            IncludedTypes = ["restaurant"]
        };
    }

    private async Task<PlacesApiResponse> RestaurantsAround(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        var request = CreateRequest(searchLocation);

        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
        {
            Content = JsonContent.Create(request),
        };

        httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
        httpRequest.Headers.Add("X-Goog-FieldMask", "places.displayName,places.rating,places.userRatingCount,places.photos,places.formattedAddress,places.reviews");
        var a = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        httpRequest.Headers.Add("X-Goog-Language", "fr");
        var httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken);

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

        if (response.Places?.Count == 0)
            _logger.LogError("No restaurants found in the area centered at ({Lat},{Lng}) with radius {Radius}", searchLocation.Latitude, searchLocation.Longitude, searchLocation.Name);

        return response;
    }

    public async Task<PlacesApiResponse> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        // Get all possible restaurants
        var restaurantsInCity = await RestaurantsAround(searchLocation, cancellationToken);

        // Remove restaurants with no photo to download or no rating
        var restaurants = restaurantsInCity.WithRatingAndPhotos();

        var filteredCount = restaurantsInCity.Places.Count - restaurants.Places.Count;
        if (filteredCount > 0)
        {
            _logger.LogInformation("Deleted {NoRatingCount} restaurants as they don't have a single user rating or no photo", filteredCount);
        }
        _logger.LogInformation("Downloading all photos for {RestauCount} restaurants", restaurants.Places.Count);

        // Enrich with photos
        var withPhotos = new PlacesApiResponse()
        {
            Places = await _photoDownloader.GetPhotos(restaurants.Places, cancellationToken)
        };
        return withPhotos;
    }
}

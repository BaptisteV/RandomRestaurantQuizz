namespace RandomRestaurantQuizz.Api.CachedClient;

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

    private HttpRequestMessage CreateRequestMessage(SearchParams searchParams)
    {
        var apiRequest = new NearbySearchRequest
        {
            LocationRestriction = new LocationRestriction
            {
                Circle = new Circle
                {
                    Center = new Center() { Latitude = searchParams.Location.Latitude, Longitude = searchParams.Location.Longitude },
                    Radius = SearchLocation.SearchRadius,
                }
            },
            IncludedTypes = ["restaurant"],
            LanguageCode = searchParams.Language,
        };

        var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
        {
            Content = JsonContent.Create(apiRequest),
        };

        httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
        httpRequest.Headers.Add("X-Goog-FieldMask", "places.displayName,places.rating,places.userRatingCount,places.photos,places.formattedAddress,places.reviews,places.location");

        return httpRequest;
    }

    private async Task<PlacesApiResponse> ReadResponse(HttpResponseMessage httpResponse, SearchLocation searchLocation, CancellationToken cancellationToken)
    {
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

    private async Task<PlacesApiResponse> RestaurantsAround(SearchParams searchParams, CancellationToken cancellationToken)
    {
        using var httpRequest = CreateRequestMessage(searchParams);

        var httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken);

        return await ReadResponse(httpResponse, searchParams.Location, cancellationToken);
    }

    public async Task<PlacesApiResponse> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken)
    {
        // Get all possible restaurants
        var restaurantsInCity = await RestaurantsAround(searchParams, cancellationToken);

        // Remove restaurants with no photo to download or no rating
        var restaurants = restaurantsInCity.WithRatingAndPhotos();

        var filteredCount = restaurantsInCity.Places.Count - restaurants.Places.Count;
        if (filteredCount > 0)
        {
            _logger.LogInformation("Deleted {NoRatingCount} restaurants as they don't have a single user rating or no photo", filteredCount);
        }
        _logger.LogInformation("Downloading all photos for {RestauCount} restaurants", restaurants.Places.Count);

        return restaurants;
    }
}

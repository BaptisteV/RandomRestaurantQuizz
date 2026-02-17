using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Places;

public class RestauQuizzClient : IQuizzApiClient
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

    private static bool IsCity(SearchLocation searchLocation)
    {
        return Locations.Cities
            .Where(l => string.Equals(l.Name, searchLocation.Name, StringComparison.OrdinalIgnoreCase))
            .ToList().Count == 1;
    }

    private SearchLocation? CityForLocation(SearchLocation searchLocation)
    {
        if (IsCity(searchLocation))
            return searchLocation;

        // If not a city, we try to find match with an existing city to
        // Prevents Google Places API call but reduces accuracy
        var nearCities = Locations.Cities
            .Select(city => new
            {
                City = city,
                Distance = GetHaversineDistance(searchLocation, city)
            })
            .Where(x => x.Distance <= SearchLocation.CityMatchRadius)
            .OrderBy(x => x.Distance)
            .ToList();

        // Match found
        if (nearCities.Count > 0)
        {
            var nearCity = nearCities[0];
            _logger.LogInformation("Found a nearby known city: changing search location to {City}, Distance {Distance:F2}m", nearCity.City.Name, nearCity.Distance);
            return nearCity.City;
        }

        _logger.LogInformation("No known city found near {City}", searchLocation.Name);
        return null;
    }

    private Uri GetRestaurantsApiUri(SearchParams searchParams)
    {
        static Uri GetCityUri(SearchParams sp)
        {
            return new Uri($"/restaurants/{sp.Location.Name}?lang={sp.Language}", UriKind.Relative);
        }

        static Uri GetGeoLocUri(SearchParams sp)
        {
            return new Uri($"/restaurants?lang={sp.Language}&lat={sp.Location.Latitude}&lng={sp.Location.Longitude}", UriKind.Relative);
        }

        var normalizedSearchLocation = CityForLocation(searchParams.Location);
        if (normalizedSearchLocation is not null)
            return GetCityUri(new SearchParams()
            {
                Language = searchParams.Language,
                Location = normalizedSearchLocation.Value
            });

        return GetGeoLocUri(searchParams);
    }

    public async Task<QuizzApiResult?> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken)
    {
        var nearCity = CityForLocation(searchParams.Location);
        if (nearCity is not null)
        {
            searchParams = new SearchParams()
            {
                Language = searchParams.Language,
                Location = nearCity.Value,
            };
        }

        var getRestaurants = GetRestaurantsApiUri(searchParams);

        var httpResponse = await _httpClient.GetAsync(getRestaurants, cancellationToken);
        if (!httpResponse.IsSuccessStatusCode)
        {
            var content = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
            _logger.LogError("Error {HttpCode} calling the Google Places API. Response content: {ResponseContent}", httpResponse.StatusCode, content);
            return null;
        }

        var jsonContent = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
        var response = JsonSerializer.Deserialize<PlacesApiResponse?>(jsonContent, _jsonOptions);

        if (response is null)
        {
            _logger.LogError("Error deserializing json : {Json}", jsonContent);
            return null;
        }

        if (response.Places.Count == 0)
            _logger.LogError("No restaurants found in the area centered at ({Lat},{Lng}) with radius {Radius}", searchParams.Location.Latitude, searchParams.Location.Longitude, searchParams.Location.Name);

        // Enrich with photos
        var withPhotos = new PlacesApiResponse()
        {
            Places = await _photoDownloader.GetPhotos(response.Places!, cancellationToken)
        };

        return new QuizzApiResult()
        {
            ApiResponse = withPhotos,
            Searched = searchParams,
        };
    }

    private static double GetHaversineDistance(SearchLocation from, SearchLocation to)
    {
        const double EarthRadiusMeters = 6_371_000.0;

        var lat1 = double.DegreesToRadians(from.Latitude);
        var lat2 = double.DegreesToRadians(to.Latitude);
        var deltaLat = double.DegreesToRadians(to.Latitude - from.Latitude);
        var deltaLon = double.DegreesToRadians(to.Longitude - from.Longitude);

        var a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2)
              + Math.Cos(lat1) * Math.Cos(lat2)
              * Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return EarthRadiusMeters * c;
    }
}

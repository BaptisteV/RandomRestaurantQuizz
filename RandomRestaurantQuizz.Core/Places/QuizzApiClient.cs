using RandomRestaurantQuizz.Core.Places.GoogleApi;
using System.Diagnostics;

namespace RandomRestaurantQuizz.Core.Places;

public class QuizzApiClient : IQuizzApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<QuizzApiClient> _logger;
    private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public QuizzApiClient(HttpClient client, ILogger<QuizzApiClient> logger)
    {
        _httpClient = client;
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
                Distance = SearchLocation.GetHaversineDistance(searchLocation, city)
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

        var sw = Stopwatch.StartNew();

        var getRestaurants = GetRestaurantsApiUri(searchParams);
        var httpResponse = await RequestApi(getRestaurants, cancellationToken);

        var response = await ReadApiResponse(searchParams, httpResponse, cancellationToken);
        if (response is null)
            return null;

        var elapsed = sw.Elapsed;
        _logger.LogInformation("Got restaurants from {GetBaseAddress}{GetUri} in {ApiElapsed}", _httpClient.BaseAddress, getRestaurants.ToString().Substring(1), elapsed);

        return new QuizzApiResult()
        {
            ApiResponse = response,
            Searched = searchParams,
        };
    }

    private async Task<HttpResponseMessage> RequestApi(Uri uri, CancellationToken cancellationToken)
    {
        var httpResponse = await _httpClient.GetAsync(uri, cancellationToken);
        if (!httpResponse.IsSuccessStatusCode)
        {
            var content = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
            _logger.LogError("Error {HttpCode} calling the Google Places API. Response content: {ResponseContent}", httpResponse.StatusCode, content);
        }

        return httpResponse;
    }

    private async Task<PlacesApiResponse?> ReadApiResponse(SearchParams searchParams, HttpResponseMessage httpResponse, CancellationToken cancellationToken)
    {
        var jsonContent = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
        var response = JsonSerializer.Deserialize<PlacesApiResponse?>(jsonContent, _jsonOptions);

        if (response is null)
        {
            _logger.LogError("Error deserializing json : {Json}", jsonContent);
            return null;
        }

        if (response.Places.Count == 0)
        {
            _logger.LogError("No restaurants found in the area centered at ({Lat},{Lng}) with radius {Radius}", searchParams.Location.Latitude, searchParams.Location.Longitude, searchParams.Location.Name);
            return null;
        }

        return response;
    }
}

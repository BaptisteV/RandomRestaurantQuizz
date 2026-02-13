
namespace RandomRestaurantQuizz.Api;

public class DuckCachedPlacesClient : ICachedPlacesClient
{
    private readonly IGooglePlacesClient _placesClient;
    private readonly ILogger<DuckCachedPlacesClient> _logger;
    private readonly PlacesCacheRepository _cache;

    public DuckCachedPlacesClient(IGooglePlacesClient placesClient, PlacesCacheRepository cache, ILogger<DuckCachedPlacesClient> logger)
    {
        _placesClient = placesClient;
        _logger = logger;
        _cache = cache;
    }

    private static string CreateCacheKey(SearchLocation loc)
    {
        // Round to reduce cache fragmentation (≈ 11m precision)
        var lat = Math.Round(loc.Latitude, 4);
        var lng = Math.Round(loc.Longitude, 4);

        return $"restaurants:v1:{lat}:{lng}:{SearchLocation.SearchRadius}";
    }

    public async Task<List<PlaceResult>> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        var cacheKey = CreateCacheKey(searchLocation);

        var cached = _cache.TryGet(cacheKey, TimeSpan.FromDays(7))?.WithRatingAndPhotos();

        if (cached is not null)
        {
            _logger.LogInformation("{LocationName} found in cache {CacheKey} with {RestauCount} restaurants", searchLocation.Name, cacheKey, cached.Count);
            return cached;
        }

        _logger.LogInformation("{LocationName} not found in cache with {CacheKey}", searchLocation.Name, cacheKey);

        var restaurantsInCity = await GetRestaurantsFromPlacesApi(searchLocation, cacheKey, cancellationToken);
        return restaurantsInCity;
    }

    private async Task<List<PlaceResult>> GetRestaurantsFromPlacesApi(SearchLocation searchLocation, string cacheKey, CancellationToken cancellationToken)
    {
        var restaurantsInCity = (await _placesClient.GetRestaurants(searchLocation, cancellationToken)).WithRatingAndPhotos().ToList();
        if (restaurantsInCity.Count == 0)
        {
            _logger.LogInformation("{LocationName} Got {RestauCount} restaurants from API", searchLocation.Name, restaurantsInCity.Count);
        }
        else
        {
            _logger.LogInformation("{LocationName} Got {RestauCount} restaurants from API, storing in {CacheKey}", searchLocation.Name, restaurantsInCity.Count, cacheKey);
            _cache.Store(cacheKey, searchLocation, restaurantsInCity);
        }

        return restaurantsInCity;
    }
}

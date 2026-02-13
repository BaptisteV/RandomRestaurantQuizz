
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
            _logger.LogInformation("Loaded {RestauCount} restaurants from cache {CacheKey}", cached.Count, cacheKey);
            return cached;
        }

        _logger.LogInformation("No cache for {CacheKey}", cacheKey);
        var restaurantsInCity = (await _placesClient.GetRestaurants(searchLocation, cancellationToken)).WithRatingAndPhotos().ToList();
        _logger.LogInformation("Got {RestauCount} restaurants from API, storing in {CacheKey}", restaurantsInCity.Count, cacheKey);
        _cache.Store(cacheKey, searchLocation, restaurantsInCity);

        return restaurantsInCity;
    }
}

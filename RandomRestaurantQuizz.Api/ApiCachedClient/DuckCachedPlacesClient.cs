namespace RandomRestaurantQuizz.Api.ApiCachedClient;

public class DuckCachedPlacesClient : ICachedPlacesClient
{
    private readonly IGooglePlacesClient _googlePlacesClient;
    private readonly ILogger<DuckCachedPlacesClient> _logger;
    private readonly PlacesCacheRepository _cache;

    private static readonly TimeSpan CACHE_DURATION = TimeSpan.FromDays(15);

    public DuckCachedPlacesClient(IGooglePlacesClient googlePlacesClient, AppDataDb dbPath, ILogger<DuckCachedPlacesClient> logger)
    {
        _googlePlacesClient = googlePlacesClient;
        _logger = logger;
        _cache = new(dbPath);
    }

    private static string CreateCacheKey(SearchLocation loc)
    {
        // Round to reduce cache fragmentation (≈ 11m precision)
        var lat = Math.Round(loc.Latitude, 4);
        var lng = Math.Round(loc.Longitude, 4);

        return $"restaurants:v1:{lat}:{lng}:{SearchLocation.SearchRadius}";
    }

    public async Task<PlacesApiResponse> GetRestaurantsWithCache(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        var cacheKey = CreateCacheKey(searchLocation);

        var cached = (await _cache.TryGet(cacheKey, CACHE_DURATION))?.WithRatingAndPhotos();

        if (cached is not null)
        {
            _logger.LogInformation("{LocationName} found in cache {CacheKey} with {RestauCount} restaurants", searchLocation.Name, cacheKey, cached.Places.Count);
            return cached;
        }

        _logger.LogInformation("{LocationName} not found in cache with {CacheKey}", searchLocation.Name, cacheKey);

        var result = await _googlePlacesClient.GetRestaurants(searchLocation, cancellationToken);
        await _cache.Store(cacheKey, searchLocation, result);
        return result;
    }
}

namespace RandomRestaurantQuizz.Api.ApiCachedClient;

public class DuckCachedPlacesClient(IGooglePlacesClient googlePlacesClient, AppDataDb dbPath, ILogger<DuckCachedPlacesClient> logger) : ICachedPlacesClient
{
    private readonly IGooglePlacesClient _googlePlacesClient = googlePlacesClient;
    private readonly ILogger<DuckCachedPlacesClient> _logger = logger;
    private readonly PlacesCacheRepository _cache = new(dbPath);

    private static readonly TimeSpan CACHE_DURATION = TimeSpan.FromDays(15);

    private static string CreateCacheKey(SearchParams searchParams)
    {
        // Round to reduce cache fragmentation (≈ 11m precision)
        var lat = Math.Round(searchParams.Location.Latitude, 4);
        var lng = Math.Round(searchParams.Location.Longitude, 4);

        return $"restaurants:v1:{searchParams.Language}:{lat}:{lng}:{SearchLocation.SearchRadius}";
    }

    public async Task<PlacesApiResponse> GetRestaurantsWithCache(SearchParams searchParams, CancellationToken cancellationToken)
    {
        var cacheKey = CreateCacheKey(searchParams);

        var cached = (await _cache.TryGet(cacheKey, CACHE_DURATION))?.WithRatingAndPhotos();

        if (cached is not null)
        {
            _logger.LogInformation("{LocationName} found in cache {CacheKey} with {RestauCount} restaurants", searchParams.Location.Name, cacheKey, cached.Places.Count);
            return cached;
        }

        _logger.LogInformation("{LocationName} not found in cache with {CacheKey}", searchParams.Location.Name, cacheKey);

        var result = await _googlePlacesClient.GetRestaurants(searchParams, cancellationToken);
        await _cache.Store(cacheKey, searchParams.Location, result);
        return result;
    }
}

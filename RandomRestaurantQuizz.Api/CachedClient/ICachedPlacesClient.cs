namespace RandomRestaurantQuizz.Api.CachedClient;

public interface ICachedPlacesClient
{
    Task<PlacesApiResponse> GetRestaurantsWithCache(SearchParams searchParams, CancellationToken cancellationToken);
}

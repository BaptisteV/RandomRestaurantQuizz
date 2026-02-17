namespace RandomRestaurantQuizz.Api.ApiCachedClient;

public interface ICachedPlacesClient
{
    Task<PlacesApiResponse> GetRestaurantsWithCache(SearchParams searchParams, CancellationToken cancellationToken);
}

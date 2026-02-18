namespace RandomRestaurantQuizz.Api.CachedClient;

public interface IGooglePlacesClient
{
    Task<PlacesApiResponse> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken);
}

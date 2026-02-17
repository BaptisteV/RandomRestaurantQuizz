namespace RandomRestaurantQuizz.Api.ApiCachedClient;

public interface IGooglePlacesClient
{
    Task<PlacesApiResponse> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken);
}

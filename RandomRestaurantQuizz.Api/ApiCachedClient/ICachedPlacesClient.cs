namespace RandomRestaurantQuizz.Api.ApiCachedClient;

public interface ICachedPlacesClient
{
    Task<PlacesApiResponse> GetRestaurantsWithCache(SearchLocation searchLocation, CancellationToken cancellationToken);
}

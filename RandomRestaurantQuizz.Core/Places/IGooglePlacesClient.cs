using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    Task<PlacesApiResponse> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken);
}

public interface IInternalPlacesClient
{
    Task<GetRestaurantsResponse?> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken);
}

public interface ICachedPlacesClient
{
    Task<PlacesApiResponse> GetRestaurantsWithCache(SearchParams searchParams, CancellationToken cancellationToken);
}

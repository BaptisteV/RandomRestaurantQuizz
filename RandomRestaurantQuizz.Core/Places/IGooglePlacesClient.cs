using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    Task<PlacesApiResponse> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken);
}

public interface IInternalPlacesClient
{
    Task<PlacesApiResponse> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken);
}

public interface ICachedPlacesClient
{
    Task<PlacesApiResponse> GetRestaurantsWithCache(SearchLocation searchLocation, CancellationToken cancellationToken);
}

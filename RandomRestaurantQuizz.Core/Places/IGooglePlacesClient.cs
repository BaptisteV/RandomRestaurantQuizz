using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    Task<PlacesApiResponse> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken);
}
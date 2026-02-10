using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    Task<List<PlaceResult>> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken);
}
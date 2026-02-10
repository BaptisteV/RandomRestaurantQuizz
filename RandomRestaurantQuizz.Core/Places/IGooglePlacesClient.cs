using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    void SetSearchLocation(SearchLocation searchLocation);
    Task<List<PlaceResult>> GetRestaurants(CancellationToken cancellationToken);
}
using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    Task<List<PlaceResult>> GetRestaurants(GeoLoc center, int radiusSize, CancellationToken cancellationToken);
}
using RandomRestaurantQuizz.Models;

namespace RandomRestaurantQuizz.Places;

public interface IPlaceFinder
{
    Task<IReadOnlyList<PlaceResult>> GetRestaurants(GeoLoc center);
}

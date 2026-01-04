using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Places;

public interface IPlaceFinder
{
    Task<IReadOnlyList<PlaceResult>> GetRestaurants(GeoLoc center);
}

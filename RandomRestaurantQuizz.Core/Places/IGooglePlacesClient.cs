using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Places
{
    public interface IGooglePlacesClient
    {
        Task<List<PlaceResult>> GetRestaurantsInCity(GeoLoc center, int radiusSize = 1000, CancellationToken cancellationToken = default);
    }
}
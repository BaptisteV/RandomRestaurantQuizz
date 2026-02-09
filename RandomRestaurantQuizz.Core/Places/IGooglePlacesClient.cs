using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public interface IGooglePlacesClient
{
    void SetSearchLocation(GeoLoc location, int radius);
    Task<List<PlaceResult>> GetRestaurants(CancellationToken cancellationToken);
}
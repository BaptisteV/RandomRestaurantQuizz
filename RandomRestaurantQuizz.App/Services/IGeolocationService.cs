namespace RandomRestaurantQuizz.App.Services;

public interface IGeolocationService
{
    Task<SearchLocation> GetCurrentLocation();
}

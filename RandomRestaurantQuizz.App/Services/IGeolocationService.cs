namespace RandomRestaurantQuizz.App.Services;

public interface IGeolocationService
{
    Task<Geoloc> GetCurrentLocation();
}

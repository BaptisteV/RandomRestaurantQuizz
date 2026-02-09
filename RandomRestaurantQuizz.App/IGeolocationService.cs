namespace RandomRestaurantQuizz.App;

public interface IGeolocationService
{
    Task<GeoLoc> GetCurrentLocation();
}

public class GeolocationService : IGeolocationService
{
    public async Task<GeoLoc> GetCurrentLocation()
    {
        var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(2));

        var location = await Geolocation.Default.GetLocationAsync(request);
        return location is null ? default : new GeoLoc
        {
            Latitude = location.Latitude,
            Longitude = location.Longitude
        };
    }
}
namespace RandomRestaurantQuizz.App.Services;

public class GeolocationService : IGeolocationService
{
    private readonly GeolocationRequest _request = new(GeolocationAccuracy.Low, TimeSpan.FromSeconds(10));
    private Geoloc? userLocation;
    public async Task<Geoloc> GetCurrentLocation()
    {
        if (userLocation is not null)
            return userLocation;
        var location = await Geolocation.Default.GetLocationAsync(_request) ?? throw new InvalidProgramException("Cannot locate user");

        var roundedLat = Math.Round(location.Latitude, 4);
        var roundedLng = Math.Round(location.Longitude, 4);

        userLocation = new Geoloc()
        {
            Latitude = roundedLat,
            Longitude = roundedLng,
        };

        return userLocation;
    }
}
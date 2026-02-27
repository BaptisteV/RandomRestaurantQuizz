namespace RandomRestaurantQuizz.App.Services;

public class GeolocationService : IGeolocationService
{
    private readonly GeolocationRequest _request = new(GeolocationAccuracy.Default);

    public async Task<SearchLocation> GetCurrentLocation()
    {
        var location = await Geolocation.Default.GetLocationAsync(_request) ?? throw new InvalidProgramException("Cannot locate user");

        var roundedLat = Math.Round(location.Latitude, 4);
        var roundedLng = Math.Round(location.Longitude, 4);
        return new SearchLocation
        {
            Geoloc = new Geoloc()
            {
                Latitude = roundedLat,
                Longitude = roundedLng,
            },
        };
    }
}
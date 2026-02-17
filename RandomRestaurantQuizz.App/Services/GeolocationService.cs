namespace RandomRestaurantQuizz.App.Services;

public class GeolocationService : IGeolocationService
{
    private readonly GeolocationRequest _request = new(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10));

    public async Task<SearchLocation> GetCurrentLocation()
    {
        var location = await Geolocation.Default.GetLocationAsync(_request) ?? throw new InvalidProgramException("Cannot locate user");

        var roundedLat = Math.Round(location.Latitude, 4);
        var roundedLng = Math.Round(location.Longitude, 4);
        return new SearchLocation
        {
            Latitude = roundedLat,
            Longitude = roundedLng,
            Name = $"({roundedLat},{roundedLng})",
        };
    }
}
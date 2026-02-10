namespace RandomRestaurantQuizz.App.Services;

public class GeolocationService : IGeolocationService
{
    public async Task<SearchLocation> GetCurrentLocation()
    {
        var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(2));

        var location = await Geolocation.Default.GetLocationAsync(request);
        return location is null ? default : new SearchLocation
        {
            Latitude = location.Latitude,
            Longitude = location.Longitude,
            Name = $"({location.Latitude},{location.Longitude})",
        };
    }
}
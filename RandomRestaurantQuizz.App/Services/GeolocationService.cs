using System.Diagnostics;

namespace RandomRestaurantQuizz.App.Services;

public class GeolocationService(ILogger<GeolocationService> logger) : IGeolocationService
{
    private readonly ILogger<GeolocationService> _logger = logger;
    private readonly GeolocationRequest _request = new(GeolocationAccuracy.Default);
    private Geoloc? userLocation;

    public async Task<Geoloc> GetCurrentLocation()
    {
        if (userLocation is not null)
            return userLocation;

        var sw = Stopwatch.StartNew();
        var location = await Geolocation.Default.GetLocationAsync(_request) ?? throw new InvalidProgramException("Cannot locate user");

        var roundedLat = Math.Round(location.Latitude, 4);
        var roundedLng = Math.Round(location.Longitude, 4);

        userLocation = new Geoloc()
        {
            Latitude = roundedLat,
            Longitude = roundedLng,
        };

        _logger.LogInformation("Got user location in {Elapsed}", sw.Elapsed);

        return userLocation;
    }
}
namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class Geoloc
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    public static double GetHaversineDistance(Geoloc from, Geoloc to)
    {
        const double EarthRadiusMeters = 6_371_000.0;

        var lat1 = double.DegreesToRadians(from.Latitude);
        var lat2 = double.DegreesToRadians(to.Latitude);
        var deltaLat = lat2 - lat1;
        var deltaLon = double.DegreesToRadians(to.Longitude - from.Longitude);

        var sinDeltaLat = Math.Sin(deltaLat / 2);
        var sinDeltaLon = Math.Sin(deltaLon / 2);

        var a = sinDeltaLat * sinDeltaLat
              + Math.Cos(lat1) * Math.Cos(lat2)
              * sinDeltaLon * sinDeltaLon;

        var c = 2 * Math.Asin(Math.Sqrt(a));

        return EarthRadiusMeters * c;
    }

    // Round to reduce cache fragmentation (≈ 11m precision)
    public static Geoloc ReducePrecision(Geoloc geoloc)
    {
        return new Geoloc
        {
            Latitude = Math.Round(geoloc.Latitude, 4),
            Longitude = Math.Round(geoloc.Longitude, 4),
        };
    }
}

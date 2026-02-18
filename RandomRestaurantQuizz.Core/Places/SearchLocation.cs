namespace RandomRestaurantQuizz.Core.Places;

public readonly struct SearchLocation
{
    public required double Latitude { get; init; }
    public required double Longitude { get; init; }
    public required string Name { get; init; }
    public static double SearchRadius { get; } = 1_000.0;
    public static double CityMatchRadius { get; } = 1_000.0;

    public static double GetHaversineDistance(SearchLocation from, SearchLocation to)
    {
        const double EarthRadiusMeters = 6_371_000.0;

        var lat1 = double.DegreesToRadians(from.Latitude);
        var lat2 = double.DegreesToRadians(to.Latitude);
        var deltaLat = double.DegreesToRadians(to.Latitude - from.Latitude);
        var deltaLon = double.DegreesToRadians(to.Longitude - from.Longitude);

        var a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2)
              + Math.Cos(lat1) * Math.Cos(lat2)
              * Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return EarthRadiusMeters * c;
    }
}

public readonly struct SearchParams
{
    public required string Language { get; init; }
    public required SearchLocation Location { get; init; }
}

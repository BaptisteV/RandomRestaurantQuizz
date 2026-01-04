using System.Collections.Immutable;

namespace RandomRestaurantQuizz;

public readonly struct GeoLoc
{
    public double Latitude { get; init; }
    public double Longitude { get; init; }

}
public static class Cities
{
    private static readonly ImmutableDictionary<string, GeoLoc> Dict = new Dictionary<string, GeoLoc>()
    {
        { "Dijon", new GeoLoc { Latitude = 47.3220, Longitude = 5.0415 }},
        { "Lyon", new GeoLoc { Latitude = 45.7640, Longitude = 4.8357 }},
        { "Marseille", new GeoLoc { Latitude = 43.2965, Longitude = 5.3698 }},
        { "Paris", new GeoLoc { Latitude = 48.8566, Longitude = 2.3522 }},
        { "Bordeaux", new GeoLoc { Latitude = 44.8378, Longitude = -0.5792 }},
    }.ToImmutableDictionary();

    public static IImmutableDictionary<string, GeoLoc> Data { get; } = Dict;
}

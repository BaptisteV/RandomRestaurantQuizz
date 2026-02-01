using System.Collections.Immutable;

namespace RandomRestaurantQuizz.Core.Data;

public static class Cities
{
    public static int DefaultRadius
    {
        get; set
        {
            if (value < 50_000)
                throw new ArgumentOutOfRangeException(nameof(DefaultRadius));
        }
    } = 1000;

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

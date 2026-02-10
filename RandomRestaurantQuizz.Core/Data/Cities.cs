using RandomRestaurantQuizz.Core.Places;
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

    private static readonly ImmutableDictionary<string, SearchLocation> Dict = new Dictionary<string, SearchLocation>()
    {
        { "Dijon", new SearchLocation { Latitude = 47.3220, Longitude = 5.0415 }},
        { "Lyon", new SearchLocation { Latitude = 45.7640, Longitude = 4.8357 }},
        { "Marseille", new SearchLocation { Latitude = 43.2965, Longitude = 5.3698 }},
        { "Paris", new SearchLocation { Latitude = 48.8566, Longitude = 2.3522 }},
        { "Bordeaux", new SearchLocation { Latitude = 44.8378, Longitude = -0.5792 }},
    }.ToImmutableDictionary();

    public static IImmutableDictionary<string, SearchLocation> Data { get; } = Dict;
}

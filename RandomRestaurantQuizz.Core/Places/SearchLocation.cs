using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Places;

public readonly struct SearchLocation
{
    public SearchLocation()
    {
    }

    public required Geoloc Geoloc { get; init; }
    public string Name { get; init; } = "";
    public static double SearchRadius { get; } = 1_000.0;
    public static double CityMatchRadius { get; } = 1_000.0;
}

public readonly struct SearchLocationWithDistance
{
    public required double Distance { get; init; }
    public required SearchLocation Location { get; init; }
}

public readonly struct SearchParams
{
    public required string Language { get; init; }
    public required SearchLocation Location { get; init; }
}

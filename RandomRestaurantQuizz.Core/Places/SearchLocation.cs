namespace RandomRestaurantQuizz.Core.Places;

public readonly struct SearchLocation
{
    public required double Latitude { get; init; }
    public required double Longitude { get; init; }
    public required string Name { get; init; }
    public static double SearchRadius { get; } = 1_000.0;
    public static double CityMatchRadius { get; } = 1_000.0;
}

public readonly struct SearchParams
{
    public required string Language { get; init; }
    public required SearchLocation Location { get; init; }
}

namespace RandomRestaurantQuizz.Core.Places;

public readonly struct SearchLocation
{
    public required double Latitude { get; init; }
    public required double Longitude { get; init; }
    public required string Name { get; init; }
    public static int SearchRadius { get; } = 1_000;
}

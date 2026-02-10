namespace RandomRestaurantQuizz.Core.Places;

public readonly struct SearchLocation
{
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public string Name { get; init; }
    public static int SearchRadius { get; } = 1_000;
}

namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class Circle
{
    public required GeoLoc Center { get; init; }
    public required double Radius { get; init; }
}

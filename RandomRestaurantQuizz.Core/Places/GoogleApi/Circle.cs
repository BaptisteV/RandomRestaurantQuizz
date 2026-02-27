namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class Circle
{
    public required Geoloc Center { get; init; }
    public required double Radius { get; init; }
}

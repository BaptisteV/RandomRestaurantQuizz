using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Places;

public sealed class NearbySearchRequest
{
    public required LocationRestriction LocationRestriction { get; init; }
    public required string[] IncludedTypes { get; init; }
}

public sealed class LocationRestriction
{
    public required Circle Circle { get; init; }
}

public sealed class Circle
{
    public required GeoLoc Center { get; init; }
    public required double Radius { get; init; }
}

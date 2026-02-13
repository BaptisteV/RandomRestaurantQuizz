namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class NearbySearchRequest
{
    public required LocationRestriction LocationRestriction { get; init; }
    public required string LanguageCode { get; init; }
    public required string[] IncludedTypes { get; init; }
}

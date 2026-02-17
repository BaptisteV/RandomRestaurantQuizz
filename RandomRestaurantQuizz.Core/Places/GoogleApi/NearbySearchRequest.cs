namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class NearbySearchRequest
{
    public required LocationRestriction LocationRestriction { get; init; }
    public required string LanguageCode { get; init; }
    public required string[] IncludedTypes { get; init; }
}

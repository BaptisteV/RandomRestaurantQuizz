namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class NearbySearchResponse
{
    [JsonPropertyName("results")]
    public List<PlaceResult>? Results { get; set; }
}

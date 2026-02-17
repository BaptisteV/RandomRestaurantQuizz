namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class NearbySearchResponse
{
    [JsonPropertyName("results")]
    public List<PlaceResult>? Results { get; set; }
}

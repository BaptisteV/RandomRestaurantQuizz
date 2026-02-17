namespace RandomRestaurantQuizz.Core.Places.GoogleApi;



public sealed class PlacesApiResponse
{
    [JsonPropertyName("places")]
    public List<PlaceResult> Places { get; set; } = [];
}

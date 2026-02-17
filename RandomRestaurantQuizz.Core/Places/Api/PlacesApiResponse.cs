namespace RandomRestaurantQuizz.Core.Places.Api;



public sealed class PlacesApiResponse
{
    [JsonPropertyName("places")]
    public List<PlaceResult> Places { get; set; } = [];
}

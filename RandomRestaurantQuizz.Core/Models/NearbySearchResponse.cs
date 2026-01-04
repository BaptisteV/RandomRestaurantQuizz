using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Models;

public sealed class NearbySearchResponse
{
    [JsonPropertyName("results")]
    public List<PlaceResult>? Results { get; set; }
}

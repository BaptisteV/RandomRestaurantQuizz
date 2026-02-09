using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class PlaceResult
{
    [JsonPropertyName("displayName")]
    public DisplayName DisplayName { get; set; } = new();

    [JsonPropertyName("rating")]
    public double Rating { get; set; }

    [JsonPropertyName("userRatingCount")]
    public int UserRatingCount { get; set; }

    [JsonPropertyName("formattedAddress")]
    public string? FormattedAddress { get; set; }

    [JsonPropertyName("photos")]
    public List<Photo> Photos { get; set; } = [];

    [JsonPropertyName("reviews")]
    public List<Review> Reviews { get; set; } = [];
}

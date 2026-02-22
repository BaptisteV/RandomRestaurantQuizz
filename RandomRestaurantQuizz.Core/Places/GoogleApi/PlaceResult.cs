namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

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

    [JsonPropertyName("location")]
    public Center Location { get; set; } = new();

    [JsonPropertyName("photos")]
    public List<Photo> Photos { get; set; } = [];

    [JsonPropertyName("reviews")]
    public List<Review> Reviews { get; set; } = [];
}

public class PlaceResultWithDistance
{
    public required double Distance { get; init; }
    public required PlaceResult Place { get; init; }
}
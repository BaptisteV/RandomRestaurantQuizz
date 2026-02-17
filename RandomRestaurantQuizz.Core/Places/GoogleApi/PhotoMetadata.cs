namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class PhotoMetadata
{
    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    // Optional: Google sometimes returns additional metadata like attribution
    [JsonPropertyName("attributions")]
    public List<string>? Attributions { get; set; }
}

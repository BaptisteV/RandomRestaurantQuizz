namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class Photo
{
    /// <summary>
    /// Resource name for the photo, used to fetch the actual image
    /// Example: "places/ChIJy.../photos/AdCG2..."
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Metadata about the photo, e.g., width and height
    /// </summary>
    [JsonPropertyName("photoMetadata")]
    public PhotoMetadata? PhotoMetadata { get; set; }

    public byte[] DownloadedImage { get; set; } = [];
}

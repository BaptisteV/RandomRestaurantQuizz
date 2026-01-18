using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Models;

public sealed class PlaceResult
{
    [JsonPropertyName("displayName")]
    public DisplayName? DisplayName { get; set; }

    [JsonPropertyName("rating")]
    public double? Rating { get; set; }

    [JsonPropertyName("userRatingCount")]
    public int? UserRatingCount { get; set; }

    [JsonPropertyName("formattedAddress")]
    public string? FormattedAddress { get; set; }

    [JsonPropertyName("photos")]
    public List<Photo>? Photos { get; set; }
}

public sealed class DisplayName
{
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

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

    public byte[]? DownloadedImage { get; set; }
}

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

public sealed class PlacesApiResponse
{
    public List<PlaceResult>? Places { get; set; }
}
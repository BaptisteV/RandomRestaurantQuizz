using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Places;
using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Places;

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

public static class PlaceResultsExtensions
{
    extension(IEnumerable<PlaceResult> source)
    {
        public List<PlaceResult> WithRatingAndPhotos()
        {
            return [..source.Where(r =>
            r.UserRatingCount > 0 &&
            r.Photos.Any(p => !string.IsNullOrWhiteSpace(p.Name)))];
        }
    }
}

public sealed class DisplayName
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";
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

    public byte[] DownloadedImage { get; set; } = [];
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
    public List<PlaceResult> Places { get; set; } = [];
}

public sealed class Review
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("relativePublishTimeDescription")]
    public string RelativePublishTimeDescription { get; set; } = string.Empty;

    [JsonPropertyName("rating")]
    public int Rating { get; set; }

    [JsonPropertyName("text")]
    public TextContent Text { get; set; } = new();

    [JsonPropertyName("authorAttribution")]
    public AuthorAttribution AuthorAttribution { get; set; } = new();
}

public sealed class TextContent
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;

    [JsonPropertyName("languageCode")]
    public string LanguageCode { get; set; } = string.Empty;
}

public sealed class AuthorAttribution
{
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("uri")]
    public string Uri { get; set; } = string.Empty;

    [JsonPropertyName("photoUri")]
    public string PhotoUri { get; set; } = string.Empty;
}
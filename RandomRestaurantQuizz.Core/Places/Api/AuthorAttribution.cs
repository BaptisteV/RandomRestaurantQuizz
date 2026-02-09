using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class AuthorAttribution
{
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = "";

    [JsonPropertyName("uri")]
    public string Uri { get; set; } = "";

    [JsonPropertyName("photoUri")]
    public string PhotoUri { get; set; } = "";
}
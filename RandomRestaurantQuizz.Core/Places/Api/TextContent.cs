using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class TextContent
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";

    [JsonPropertyName("languageCode")]
    public string LanguageCode { get; set; } = "";
}

namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class TextContent
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";

    [JsonPropertyName("languageCode")]
    public string LanguageCode { get; set; } = "";
}

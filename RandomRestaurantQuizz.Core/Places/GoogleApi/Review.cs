namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class Review
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("relativePublishTimeDescription")]
    public string RelativePublishTimeDescription { get; set; } = "";

    [JsonPropertyName("rating")]
    public int Rating { get; set; }

    [JsonPropertyName("text")]
    public TextContent Text { get; set; } = new();

    [JsonPropertyName("authorAttribution")]
    public AuthorAttribution AuthorAttribution { get; set; } = new();
}

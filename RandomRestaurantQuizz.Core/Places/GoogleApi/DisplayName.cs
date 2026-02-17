namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public sealed class DisplayName
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";
}

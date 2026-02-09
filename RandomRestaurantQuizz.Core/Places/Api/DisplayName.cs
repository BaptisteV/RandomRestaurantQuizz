using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.Core.Places.Api;

public sealed class DisplayName
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";
}

namespace RandomRestaurantQuizz.Core;

public class SecretsJson
{
    [JsonPropertyName("GOOGLE_PLACES_API_KEY")]
    public string GooglePlacesApiKey { get; set; } = "";
}

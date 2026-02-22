namespace RandomRestaurantQuizz.Core.Config;

public class SecretsJson
{
    [JsonPropertyName("GOOGLE_PLACES_API_KEY")]
    public string GooglePlacesApiKey { get; set; } = "";
}

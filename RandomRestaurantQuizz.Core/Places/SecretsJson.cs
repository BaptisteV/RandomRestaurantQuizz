namespace RandomRestaurantQuizz.Core.Places;

public class SecretsJson
{
    [JsonPropertyName("GOOGLE_PLACES_API_KEY")]
    public string GooglePlacesApiKey { get; set; } = "";
}

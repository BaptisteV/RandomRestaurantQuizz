namespace RandomRestaurantQuizz.Core.Config;

public class ApiUrls
{
    [JsonPropertyName("QuizzApi")]
    public string QuizzApi { get; set; } = "";
    [JsonPropertyName("GooglePlacesApi")]
    public string GooglePlacesApi { get; set; } = "";
    [JsonPropertyName("GooglePlacesApi")]
    public string GooglePhotosApi { get; set; } = "";
}

using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Places.Api;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public class GooglePlacesStaticClient(HttpClient _, IPhotoDownloader photoDownloader, ILogger<GooglePlacesStaticClient> logger) : IGooglePlacesClient
{
    private static readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public async Task<List<PlaceResult>> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        // Read "fake" JSON to avoid hitting Search API to debug
        var json = JsonSerializer.Deserialize<PlacesApiResponse>(TestData.JsonDij, _jsonOptions);

        // Get all possible restaurants
        var restaurantsInCity = json!.Places ?? [];

        // Remove restaurants with no photo to download or no rating
        var restaurants = restaurantsInCity.WithRatingAndPhotos();

        var filteredCount = restaurantsInCity.Count - restaurants.Count;
        if (filteredCount > 0)
        {
            logger.LogInformation("Deleted {NoRatingCount} restaurants as they don't have a single user rating or no photo", filteredCount);
        }
        logger.LogInformation("Downloading all photos for {RestauCount} restaurants", restaurants.Count);

        return await photoDownloader.GetPhotos(restaurants, cancellationToken);
    }
}

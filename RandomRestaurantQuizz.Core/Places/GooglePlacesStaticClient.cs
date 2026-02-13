using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places.Api;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public class GooglePlacesStaticClient(HttpClient _, IPhotoDownloader photoDownloader, ILogger<GooglePlacesStaticClient> logger) : IGooglePlacesClient
{
    private static readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public async Task<PlacesApiResponse> GetRestaurants(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        // Read "fake" JSON to avoid hitting Search API to debug
        var response = JsonSerializer.Deserialize<PlacesApiResponse>(TestData.JsonDij, _jsonOptions)!;

        // Remove restaurants with no photo to download or no rating
        var restaurants = response.WithRatingAndPhotos();

        var filteredCount = response.Places.Count - restaurants.Places.Count;
        if (filteredCount > 0)
        {
            logger.LogInformation("Deleted {NoRatingCount} restaurants as they don't have a single user rating or no photo", filteredCount);
        }
        logger.LogInformation("Downloading all photos for {RestauCount} restaurants", restaurants.Places.Count);

        // Enrich with photos
        var withPhotos = new PlacesApiResponse()
        {
            Places = await photoDownloader.GetPhotos(restaurants.Places, cancellationToken)
        };
        return withPhotos;
    }
}

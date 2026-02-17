using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Places;

public class GooglePlacesStaticClient(
#pragma warning disable CS9113 // Parameter is unread.
    HttpClient _,
#pragma warning restore CS9113 // Parameter is unread.
    IPhotoDownloader photoDownloader,
    ILogger<GooglePlacesStaticClient> logger) : IQuizzApiClient
{
    private static readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public async Task<QuizzApiResult?> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken)
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
        return new QuizzApiResult()
        {
            ApiResponse = new PlacesApiResponse()
            {
                Places = await photoDownloader.GetPhotos(restaurants.Places, cancellationToken)
            },
            Searched = searchParams,
        };
    }
}

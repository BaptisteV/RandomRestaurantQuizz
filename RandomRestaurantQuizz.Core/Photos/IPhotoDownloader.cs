using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Photos;

public interface IPhotoDownloader
{
    /// <summary>
    /// Returns the place result enriched with photos
    /// Download / Disk fetch the first photo and gets the others in the background
    /// </summary>
    /// <param name="placeResult">Place result to download photos for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Place result with the first photo data set</returns>
    Task<PlaceResult> LazyGetPhotos(PlaceResult placeResult, CancellationToken cancellationToken);
}
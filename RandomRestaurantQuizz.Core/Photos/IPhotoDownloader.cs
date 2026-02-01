namespace RandomRestaurantQuizz.Core.Photos
{
    public interface IPhotoDownloader
    {
        Task<List<PlaceResult>> GetPhotos(List<PlaceResult> placeResults, CancellationToken cancellationToken);
    }
}
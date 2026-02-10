namespace RandomRestaurantQuizz.Api;

public class NoOpPhotoDownloader : IPhotoDownloader
{
    public Task<List<PlaceResult>> GetPhotos(List<PlaceResult> placeResults, CancellationToken cancellationToken)
    {
        return Task.FromResult(placeResults);
    }
}

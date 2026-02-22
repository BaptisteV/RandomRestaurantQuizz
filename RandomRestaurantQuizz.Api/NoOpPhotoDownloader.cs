namespace RandomRestaurantQuizz.Api;

public class NoOpPhotoDownloader : IPhotoDownloader
{
    public Task<PlaceResult> LazyGetPhotos(PlaceResult placeResult, CancellationToken cancellationToken)
    {
        return Task.FromResult(placeResult);
    }
}

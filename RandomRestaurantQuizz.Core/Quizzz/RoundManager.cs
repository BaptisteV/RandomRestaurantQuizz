using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class RoundManager(IScoreRepository _scoreSaver, IPhotoDownloader _photoDownloader, IQuizzApiClient _restauClient, ILogger<RoundManager> _logger)
{
    private int PhotoIndex = 0;
    private int RoundNumber = 0;
    private int RoundCount = 0;
    private PlaceResult CurrentPlace = new();
    private SearchParams SearchParams;
    private readonly Player _player = new();
    private readonly Queue<PlaceResult> _nextRestaurants = [];

    public async Task Init(SearchParams searchParams, SearchLocation userLocation, CancellationToken cancellationToken)
    {
        await _scoreSaver.Init();

        var restaurants = await _restauClient.GetRestaurants(searchParams, cancellationToken);
        if (restaurants is null || restaurants.ApiResponse.Places.Count == 0)
        {
            _logger.LogError("No restaurants found for location {LocationName}", searchParams.Location.Name);
            return;
        }

        var actualSearchParams = restaurants.Searched;
        SearchParams = actualSearchParams;

        var nearRestaurants = restaurants.ApiResponse.Places.OrderByDistance(userLocation);
        foreach (var r in nearRestaurants)
        {
            _logger.LogInformation("{RestauName} is {Distance:F2}m away from user", r.Place.DisplayName.Text, r.Distance);
            _nextRestaurants.Enqueue(r.Place);
        }

        if (_nextRestaurants.Count == 0)
        {
            _logger.LogError("No restaurants found for location {LocationName}", SearchParams.Location.Name);
            return;
        }
        RoundCount = _nextRestaurants.Count;
    }

    public async Task<PlaceResult> NextRestaurant(CancellationToken cancellationToken)
    {
        PhotoIndex = 0;
        RoundNumber++;
        CurrentPlace = _nextRestaurants.Dequeue();
        await _photoDownloader.LazyGetPhotos(CurrentPlace, cancellationToken);
        return CurrentPlace;
    }

    public RestaurantChangedEvent RestaurantChanged()
    {
        var scoreEvent = new ScoreChangedEvent(0, 0, 0);
        var photoEvent = new PhotoChangedEvent(CurrentPlace.Photos[0].DownloadedImage);
        var round = new Round(
            CurrentPlace.DisplayName.Text,
            SearchParams.Location.Name,
            CurrentPlace.UserRatingCount,
            RoundCount,
            RoundNumber);

        return new RestaurantChangedEvent(round, CurrentPlace.Reviews, scoreEvent, photoEvent);
    }

    public async Task<RoundsFinishedEvent> RoundsFinished()
    {
        await _scoreSaver.SaveScore(new Score { Value = _player.TotalScore(), Timestamp = DateTime.Now, LocationName = CurrentPlace.DisplayName.Text });

        var pbs = (await _scoreSaver.ReadScores())
            .SortBest()
            .ToList();

        return new RoundsFinishedEvent(_player.TotalScore(), pbs);
    }

    public void SaveAnswer(double guessedRating)
    {
        var guess = new Guess(CurrentPlace, guessedRating);
        _player.AddGuess(guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}\tReal ranking {RealRank}", guessedRating, CurrentPlace.DisplayName.Text, CurrentPlace.Rating);
        _logger.LogInformation("Round score: {RoundScore}, Total: {TotalScore}", guess.RoundScore(), _player.TotalScore());
    }

    public PhotoChangedEvent NextPhoto()
    {
        PhotoIndex = Math.Min(PhotoIndex + 1, CurrentPlace.Photos.Count - 1);
        return new PhotoChangedEvent(CurrentPlace.Photos[PhotoIndex].DownloadedImage);
    }
    public PhotoChangedEvent PreviousPhoto()
    {
        PhotoIndex = Math.Max(0, PhotoIndex - 1);
        return new PhotoChangedEvent(CurrentPlace.Photos[PhotoIndex].DownloadedImage);
    }

    public bool RoundFinished() => _nextRestaurants.Count == 0;
}

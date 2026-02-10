using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Places.Api;
using RandomRestaurantQuizz.Core.Quizzz.Events;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class QuizzGame(IGooglePlacesClient restauClient, ILogger<QuizzGame> logger, IScoreRepository scoreSaver) : IQuizzGame
{
    private readonly ILogger<QuizzGame> _logger = logger;

    private readonly IGooglePlacesClient _restauClient = restauClient;
    private readonly Queue<PlaceResult> _nextRestaurants = [];
    private readonly IScoreRepository _scoreSaver = scoreSaver;

    private Player _player = new();
    private PlaceResult _currentPlace = new();
    private int photoIndex = 0;
    private int _roundNumber = 1;
    private int _roundCount = 0;
    private SearchLocation _searchLocation = new();
    private byte[] Image => _currentPlace.Photos[photoIndex].DownloadedImage;

    public Func<ScoreChangedEvent, Task> ScoreChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(ScoreChanged)} handler");
    public Func<PhotoChangedEvent, Task> PhotoChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(PhotoChanged)} handler");
    public Func<RoundsFinishedEvent, Task> RoundFinished { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(RoundFinished)} handler");
    public Func<RestaurantChangedEvent, Task> RestaurantChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(RestaurantChanged)} handler");

    public async Task InitRound(SearchLocation searchLocation, CancellationToken cancellationToken)
    {
        _searchLocation = searchLocation;
        await _scoreSaver.Init();

        _player = new Player();
        _nextRestaurants.Clear();

        _restauClient.SetSearchLocation(_searchLocation);
        var restaurants = await _restauClient.GetRestaurants(cancellationToken);

        foreach (var restaurant in restaurants)
        {
            _nextRestaurants.Enqueue(restaurant);
        }

        if (_nextRestaurants.Count == 0)
        {
            _logger.LogError("No restaurants found for location {LocationName}", _searchLocation.Name);
            return;
        }

        _roundNumber = 1;
        _roundCount = _nextRestaurants.Count;

        _currentPlace = _nextRestaurants.Dequeue();

        var scoreEvent = new ScoreChangedEvent(0, 0, 0);
        var photoEvent = new PhotoChangedEvent(_currentPlace.Photos[0].DownloadedImage!);
        var round = new Round(
            _currentPlace.DisplayName.Text,
            _searchLocation.Name,
            _currentPlace.UserRatingCount,
            _roundCount,
            _roundNumber);

        await RestaurantChanged(new RestaurantChangedEvent(round, _currentPlace.Reviews, scoreEvent, photoEvent));
    }

    public async Task Answer(double guessedRating)
    {
        if (_nextRestaurants.Count == 0)
        {
            await _scoreSaver.SaveScore(new Score { Value = _player.TotalScore(), Timestamp = DateTime.Now });

            var pbs = (await _scoreSaver.ReadScores())
                .SortBest()
                //.Take(20)
                .ToList();

            await RoundFinished(new RoundsFinishedEvent(_player.TotalScore(), pbs));
            return;
        }

        _currentPlace = _nextRestaurants.Dequeue();

        var guess = new Guess(_currentPlace, guessedRating);
        _player.AddGuess(guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}\tReal ranking {RealRank}", guessedRating, _currentPlace.DisplayName.Text, _currentPlace.Rating);
        _logger.LogInformation("Round score: {RoundScore}, Total: {TotalScore}", guess.RoundScore(), _player.TotalScore());

        var scoreEvent = new ScoreChangedEvent(_player.TotalScore(), guess.RoundScore(), _currentPlace.Rating);
        var photoEvent = new PhotoChangedEvent(Image);
        var round = new Round(_currentPlace.DisplayName.Text,
            _searchLocation.Name,
            _currentPlace.UserRatingCount,
            _roundCount,
            ++_roundNumber);
        await RestaurantChanged(new RestaurantChangedEvent(
            round,
            _currentPlace.Reviews,
            scoreEvent,
            photoEvent));

        await PhotoChanged(new PhotoChangedEvent(Image));
        await ScoreChanged(new ScoreChangedEvent(_player.TotalScore(), guess.RoundScore(), _currentPlace.Rating));
    }

    public void SetSearchLocation(SearchLocation searchLocation)
    {
        _restauClient.SetSearchLocation(searchLocation);
    }

    public async Task NextPhoto()
    {
        photoIndex = Math.Min(photoIndex + 1, _currentPlace.Photos.Count - 1);
        await PhotoChanged(new PhotoChangedEvent(Image));
    }

    public async Task PreviousPhoto()
    {
        photoIndex = Math.Max(0, photoIndex - 1);
        await PhotoChanged(new PhotoChangedEvent(Image));
    }
}

using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Quizz(IGooglePlacesClient restauClient, ILogger<Quizz> logger, IScoreSaver scoreSaver) : IQuizz
{
    private readonly ILogger<Quizz> _logger = logger;

    private Player _player = new();
    private readonly Queue<PlaceResult> _places = [];
    private PlaceResult _currentPlace = new();
    private QuizzModel _model = new();
    private readonly IScoreSaver _scoreSaver = scoreSaver;

    public Func<QuizzModel, Task> ScoreChanged { get; set; } = (_) => Task.CompletedTask;
    public Func<QuizzModel, Task> PhotoChanged { get; set; } = (_) => Task.CompletedTask;
    public Func<QuizzModel, Task> RoundFinished { get; set; } = (_) => Task.CompletedTask;

    public async Task InitRound(CancellationToken cancellationToken)
    {
        Cities.Data.TryGetValue("Dijon", out var city);

        var restaurants = await restauClient.GetRestaurants(city, Cities.DefaultRadius, cancellationToken);
        _model = new QuizzModel();
        _player = new Player();
        _places.Clear();
        foreach (var restaurant in restaurants)
        {
            _places.Enqueue(restaurant);
        }
        await ChangeCurrentPlace();

        await ScoreChanged(_model);
        await PhotoChanged(_model);
    }

    private async Task ChangeCurrentPlace()
    {
        _currentPlace = _places.Dequeue();

        _model = new QuizzModel();
        _model.RestaurantName = _currentPlace.DisplayName?.Text ?? "";
        _model.RatingCount = _currentPlace.UserRatingCount ?? 0;
        _model.Image = _currentPlace.Photos?.FirstOrDefault()?.DownloadedImage ?? [];
    }

    public async Task Answer(double guessedValue)
    {
        if (_places.Count == 0)
        {
            _model.PersonalBests = await _scoreSaver.ReadScores();
            await RoundFinished(_model);
            return;
        }

        await ChangeCurrentPlace();
        var guess = new Guess()
        {
            GuessedScore = guessedValue,
            Place = _currentPlace
        };

        _player.NewGuess(guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}\tReal ranking {RealRank}", guess.GuessedScore, _currentPlace.DisplayName?.Text, _currentPlace.Rating);
        _logger.LogInformation("Score: {Score}, Total: {TotalScore}", guess.GuessScore(), _player.TotalScore());

        _model.RestaurantName = _currentPlace.DisplayName?.Text ?? "";
        _model.RatingCount = _currentPlace.UserRatingCount ?? 0;
        _model.Image = _currentPlace.Photos?.FirstOrDefault()?.DownloadedImage ?? [];
        _model.TotalScore = (int)_player.TotalScore();
        _model.LastScoreUpdate = (int)guess.GuessScore();
        _model.LastRating = guess.Place.Rating ?? 0.0;

        await ScoreChanged(_model);
        await PhotoChanged(_model);
    }

    private int _currentPhotoIndex = 0;

    public async Task NextPhoto()
    {
        var maxIndex = _currentPlace!.Photos!.Count - 1;
        var nextIndex = Math.Min(_currentPhotoIndex + 1, maxIndex);
        _currentPhotoIndex = nextIndex;
        _model.Image = _currentPlace!.Photos?[nextIndex].DownloadedImage ?? [];

        await PhotoChanged(_model);
    }

    public async Task PreviousPhoto()
    {
        var prevIndex = Math.Max(0, _currentPhotoIndex - 1);
        _currentPhotoIndex = prevIndex;
        _model.Image = _currentPlace!.Photos?[prevIndex].DownloadedImage ?? [];

        await PhotoChanged(_model);
    }
}

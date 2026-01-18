using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Quizz(IPlaceFinder placeFinder, ILogger<Quizz> logger) : IQuizz
{
    private readonly IPlaceFinder _placeFinder = placeFinder;
    private readonly ILogger<Quizz> _logger = logger;

    private readonly Player _player = new();
    private readonly Queue<PlaceResult> _places = [];
    private PlaceResult _currentPlace;
    private readonly QuizzModel _model = new();

    public Func<QuizzModel, Task> ScoreChanged { get; set; } = (_) => Task.CompletedTask;
    public Func<QuizzModel, Task> PhotoChanged { get; set; } = (_) => Task.CompletedTask;

    public async Task DownloadRestaurants()
    {
        Cities.Data.TryGetValue("Dijon", out var city);
        var restaurants = await _placeFinder.GetRestaurants(city);
        foreach (var restaurant in restaurants)
        {
            _places.Enqueue(restaurant);
        }
        _currentPlace = _places.Dequeue();

        _model.RestaurantName = _currentPlace.DisplayName?.Text ?? "";
        _model.Image = _currentPlace.Photos?.FirstOrDefault()?.DownloadedImage!;

        await ScoreChanged(_model);
        await PhotoChanged(_model);
    }

    public async Task Answer(double guessedValue)
    {
        if (_places.Count == 0)
        {
            _logger.LogError("No place to answer");
            return;
        }

        _currentPlace = _places.Dequeue();
        var guess = new Guess()
        {
            GuessedScore = guessedValue,
            Place = _currentPlace
        };

        _player.NewGuess(guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}", guess.GuessedScore, _currentPlace.DisplayName?.Text);
        _logger.LogInformation("Real ranking {RealRank}", _currentPlace.Rating);
        _logger.LogInformation("Score: {Score}, Total: {TotalScore}", guess.Score(), _player.Score());

        _model.RestaurantName = _currentPlace.DisplayName?.Text ?? "";
        _model.Image = _currentPlace.Photos?.FirstOrDefault()?.DownloadedImage!;
        _model.TotalScore = (int)_player.Score();
        _model.LastScoreUpdate = (int)guess.Score();
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
        _model.Image = _currentPlace!.Photos?[nextIndex].DownloadedImage!;

        await PhotoChanged(_model);
    }

    public async Task PreviousPhoto()
    {
        var prevIndex = Math.Max(0, _currentPhotoIndex - 1);
        _currentPhotoIndex = prevIndex;
        _model.Image = _currentPlace!.Photos?[prevIndex].DownloadedImage!;

        await PhotoChanged(_model);
    }
}

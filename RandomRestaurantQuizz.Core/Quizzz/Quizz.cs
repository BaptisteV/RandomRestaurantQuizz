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
        _model.CurrentPlace = _places.Dequeue();
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

        var answered = _places.Dequeue();
        var guess = new Guess()
        {
            GuessedScore = guessedValue,
            Place = answered
        };

        _player.NewGuess(guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}", guess.GuessedScore, answered.DisplayName?.Text);
        _logger.LogInformation("Real ranking {RealRank}", answered.Rating);
        _logger.LogInformation("Score: {Score}, Total: {TotalScore}", guess.Score(), _player.Score());

        _model.LastGuess = guess;
        _model.CurrentPlace = answered;
        _model.CurrentPhotoIndex = 0;
        _model.Player = _player;

        await ScoreChanged(_model);
        await PhotoChanged(_model);
    }

    public async Task NextPhoto()
    {
        var maxIndex = _model.CurrentPlace!.Photos!.Count - 1;
        _model.CurrentPhotoIndex = Math.Min(_model.CurrentPhotoIndex + 1, maxIndex);
        await PhotoChanged(_model);
    }

    public async Task PreviousPhoto()
    {
        _model.CurrentPhotoIndex = Math.Max(0, _model.CurrentPhotoIndex - 1);
        await PhotoChanged(_model);
    }
}

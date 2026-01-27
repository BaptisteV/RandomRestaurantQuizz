using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class QuizzGame(IGooglePlacesClient restauClient, ILogger<QuizzGame> logger, IScoreSaver scoreSaver) : IQuizzGame
{
    private readonly ILogger<QuizzGame> _logger = logger;

    private readonly Queue<PlaceResult> _places = [];
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
        _places.Clear();
        foreach (var restaurant in restaurants)
        {
            _places.Enqueue(restaurant);
        }
        var currentPlace = _places.Dequeue();

        _model = _model.NextRestaurant(currentPlace, _model.Player, null);

        await ScoreChanged(_model);
        await PhotoChanged(_model);
    }

    public async Task Answer(double guessedValue)
    {
        if (_places.Count == 0)
        {
            _model.PersonalBests = await _scoreSaver.ReadScores();
            await _scoreSaver.SaveScore(_model.Player.TotalScore());
            await RoundFinished(_model);
            return;
        }
        var currentPlace = _places.Dequeue();

        var guess = new Guess()
        {
            GuessedScore = guessedValue,
            Place = currentPlace,
        };

        _model.Player.NewGuess(guess);
        _model = _model.NextRestaurant(currentPlace, _model.Player, guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}\tReal ranking {RealRank}", guess.GuessedScore, _model.CurrentPlace.DisplayName?.Text, _model.CurrentPlace.Rating);
        _logger.LogInformation("Score: {Score}, Total: {TotalScore}", guess.GuessScore(), _model.Player.TotalScore());

        await ScoreChanged(_model);
        await PhotoChanged(_model);
    }

    public async Task NextPhoto()
    {
        _model = _model.NextPhoto();
        await PhotoChanged(_model);
    }

    public async Task PreviousPhoto()
    {
        _model = _model.PreviousPhoto();
        await PhotoChanged(_model);
    }
}

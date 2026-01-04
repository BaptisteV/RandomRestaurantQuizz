using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Data;
using RandomRestaurantQuizz.Models;
using RandomRestaurantQuizz.Places;

namespace RandomRestaurantQuizz.Quizzz;

public class Quizz : IQuizz
{
    private readonly IPlaceFinder _placeFinder;
    private readonly Player _player = new();
    private readonly Queue<PlaceResult> _places = [];
    private readonly ILogger<Quizz> _logger;

    public Quizz(IPlaceFinder placeFinder, ILogger<Quizz> logger)
    {
        _placeFinder = placeFinder;
        _logger = logger;
    }

    public async Task Init()
    {
        Cities.Data.TryGetValue("Dijon", out var city);
        var restaurants = await _placeFinder.GetRestaurants(city);
        foreach (var restaurant in restaurants)
        {
            _places.Enqueue(restaurant);
        }
    }

    public void Answer(double guessedValue)
    {
        var answered = _places.Dequeue();
        var guess = new Guess()
        {
            GuessedScore = guessedValue,
            Place = answered
        };
        _player.Guesses.Add(guess);

        _logger.LogInformation("Answered     {Guess} for {PlaceName}", guess.GuessedScore, answered.DisplayName?.Text);
        _logger.LogInformation("Real ranking {RealRank}", answered.Rating);
        _logger.LogInformation("Score: {Score}", _player.Score());

        _model.GuessInput = guessedValue;
        _model.ActivePlaceIndex += 1;
        _model.PlacesToBeAnswered = [.. _places];
    }

    private readonly QuizzModel _model = new();
    public QuizzModel CurrentState()
    {
        return _model;
    }
}

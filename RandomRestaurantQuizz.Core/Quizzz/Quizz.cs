using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Quizz : IQuizz
{
    private readonly IPlaceFinder _placeFinder;
    private readonly Player _player = new();
    private readonly Queue<PlaceResult> _places = [];
    private readonly QuizzModel _model = new();
    private readonly ILogger<Quizz> _logger;

    private readonly ResourceSoundEffects _soundEffects;
    public Quizz(IPlaceFinder placeFinder, ResourceSoundEffects soundEffects, ILogger<Quizz> logger)
    {
        _placeFinder = placeFinder;
        _soundEffects = soundEffects;
        _logger = logger;
    }

    public async Task Init()
    {
        await _soundEffects.Init();
        Cities.Data.TryGetValue("Dijon", out var city);
        var restaurants = await _placeFinder.GetRestaurants(city);
        foreach (var restaurant in restaurants)
        {
            _places.Enqueue(restaurant);
        }
        _model.CurrentPlace = _places.Dequeue();
    }

    public void Answer(double guessedValue)
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

        var scoreDifference = Math.Abs(guess.GuessedScore - answered.Rating ?? 0.0);
        _player.Guesses.Add(guess);
        if (scoreDifference < 0.5)
        {
            _soundEffects.PlayWin();
        }
        else
        {
            _soundEffects.PlayLoose();
        }
        _logger.LogInformation("Answered     {Guess} for {PlaceName}", guess.GuessedScore, answered.DisplayName?.Text);
        _logger.LogInformation("Real ranking {RealRank}", answered.Rating);
        _logger.LogInformation("Score: {Score}", _player.Score());

        _model.CurrentPlace = answered;
        _model.Player = _player;

    }

    public QuizzModel CurrentState()
    {
        return _model;
    }

    public void NextPhoto()
    {
        var maxIndex = _model.CurrentPlace!.Photos!.Count - 1;
        _model.CurrentPhotoIndex = Math.Min(_model.CurrentPhotoIndex + 1, maxIndex);
    }

    public void PreviousPhoto()
    {
        _model.CurrentPhotoIndex = Math.Max(0, _model.CurrentPhotoIndex - 1);
    }
}

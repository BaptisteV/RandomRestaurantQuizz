using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Quizzz.Scores;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class ScoreChangedEvent
{
    public ScoreChangedEvent(int totalScore, double roundScore, string locationName, int userRatingCount, double locationRating)
    {
        TotalScore = totalScore;
        RoundScore = roundScore;
        LocationLabel = $"{locationName} ({userRatingCount} 👤)";
        ScoreDiff = $" +{roundScore} ({locationRating:n1})";
    }
    public int TotalScore { get; }
    public double RoundScore { get; }
    public string LocationLabel { get; }
    public string ScoreDiff { get; }
}

public class PhotoChangedEvent
{
    public PhotoChangedEvent(byte[] image)
    {
        Source = ImageSource.FromStream(() => new MemoryStream(image));
    }

    public ImageSource Source { get; }
}

public class RoundFinishedEvent
{
    public RoundFinishedEvent(double totalScore, List<Score> pbs)
    {
        TotalScore = totalScore;
        PersonalBests = pbs;
    }

    public double TotalScore { get; }
    public List<Score> PersonalBests { get; }
}

public class QuizzGame(IGooglePlacesClient restauClient, ILogger<QuizzGame> logger, IScoreSaver scoreSaver) : IQuizzGame
{
    private readonly ILogger<QuizzGame> _logger = logger;

    private readonly Queue<PlaceResult> _places = [];
    private QuizzData _model = new();
    private readonly IScoreSaver _scoreSaver = scoreSaver;

    public Func<ScoreChangedEvent, Task> ScoreChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(ScoreChanged)} handler");
    public Func<PhotoChangedEvent, Task> PhotoChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(PhotoChanged)} handler");
    public Func<RoundFinishedEvent, Task> RoundFinished { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(RoundFinished)} handler");

    public async Task InitRound((string Name, GeoLoc Geoloc) location, CancellationToken cancellationToken)
    {
        await _scoreSaver.Init();

        _model = new QuizzData();
        _places.Clear();

        restauClient.SetSearchLocation(location.Geoloc, Cities.DefaultRadius);
        var restaurants = await restauClient.GetRestaurants(cancellationToken);

        foreach (var restaurant in restaurants)
        {
            _places.Enqueue(restaurant);
        }
        var currentPlace = _places.Dequeue();

        _model = _model.NextRestaurant(currentPlace, null);

        await ScoreChanged(new ScoreChangedEvent(0, 0, currentPlace.DisplayName.Text, currentPlace.UserRatingCount, currentPlace.Rating));
        await PhotoChanged(new PhotoChangedEvent(_model.Image));
    }

    public async Task Answer(double guessedRating)
    {
        if (_places.Count == 0)
        {
            await _scoreSaver.SaveScore(new Score { Value = _model.Player.TotalScore(), Timestamp = DateTime.Now });

            var pbs = (await _scoreSaver.ReadScores())
                .SortBest()
                //.Take(MaxScoreCount)
                .ToList();
            _model.PersonalBests = pbs;
            await RoundFinished(new RoundFinishedEvent(_model.Player.TotalScore(), pbs));
            return;
        }

        var currentPlace = _places.Dequeue();

        var guess = new Guess()
        {
            GuessedRating = guessedRating,
            Place = currentPlace,
        };

        _model.Player.AddGuess(guess);
        _model = _model.NextRestaurant(currentPlace, guess);

        _logger.LogInformation("Answered {Guess} for {PlaceName}\tReal ranking {RealRank}", guess.GuessedRating, _model.CurrentPlace.DisplayName.Text, _model.CurrentPlace.Rating);
        _logger.LogInformation("Round score: {RoundScore}, Total: {TotalScore}", guess.RoundScore(), _model.Player.TotalScore());


        await PhotoChanged(new PhotoChangedEvent(_model.Image));
        await ScoreChanged(new ScoreChangedEvent(_model.Player.TotalScore(), guess.RoundScore(), currentPlace.DisplayName.Text, currentPlace.UserRatingCount, currentPlace.Rating));
    }

    public void SetSearchLocation(GeoLoc geoloc, int radius)
    {
        restauClient.SetSearchLocation(geoloc, radius);
    }

    public async Task NextPhoto()
    {
        _model = _model.NextPhoto();
        await PhotoChanged(new PhotoChangedEvent(_model.Image));
    }

    public async Task PreviousPhoto()
    {
        _model = _model.PreviousPhoto();
        await PhotoChanged(new PhotoChangedEvent(_model.Image));
    }
}

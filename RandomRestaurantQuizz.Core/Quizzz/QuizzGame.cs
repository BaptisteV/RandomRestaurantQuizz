namespace RandomRestaurantQuizz.Core.Quizzz;

public class QuizzGame(RoundManager roundManager) : IQuizzGame
{
    private readonly RoundManager _roundManager = roundManager;

    public Func<ScoreChangedEvent, Task> ScoreChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(ScoreChanged)} handler");
    public Func<PhotoChangedEvent, Task> PhotoChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(PhotoChanged)} handler");
    public Func<RoundsFinishedEvent, Task> RoundFinished { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(RoundFinished)} handler");
    public Func<RestaurantChangedEvent, Task> RestaurantChanged { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(RestaurantChanged)} handler");

    public async Task InitRound(SearchParams searchParams, SearchLocation userLocation, CancellationToken cancellationToken)
    {
        await _roundManager.Init(searchParams, userLocation, cancellationToken);

        await _roundManager.NextRestaurant(cancellationToken);

        await RestaurantChanged(_roundManager.RestaurantChanged());
    }

    public async Task Answer(double guessedRating, CancellationToken cancellationToken)
    {
        if (_roundManager.RoundFinished())
        {
            await RoundFinished(await _roundManager.RoundsFinished());
            return;
        }

        var scoreEvent = _roundManager.SaveAnswer(guessedRating);
        await ScoreChanged(scoreEvent);

        await _roundManager.NextRestaurant(cancellationToken);

        var e = _roundManager.RestaurantChanged();

        await Task.WhenAll(
            PhotoChanged(e.PhotoChangedEvent),
            RestaurantChanged(e));
    }

    public async Task NextPhoto()
    {
        await PhotoChanged(_roundManager.NextPhoto());
    }

    public async Task PreviousPhoto()
    {
        await PhotoChanged(_roundManager.PreviousPhoto());
    }
}

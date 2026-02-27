using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

internal class Game2(RoundManager roundManager, ISoundEffect soundEffect, VmUpdater vmUpdater) : IQuizzGame
{
    private readonly RoundManager _roundManager = roundManager;
    private readonly ISoundEffect _soundEffects = soundEffect;
    private readonly VmUpdater vmUpdater = vmUpdater;
    private ITransitions? _transitions;

    public Func<RoundsFinishedEvent, Task> RoundFinished { get; set; } = (_) => throw new NotImplementedException($"Missing {nameof(RoundFinished)} handler");

    public async Task InitRound(SearchParams searchParams, Geoloc userLocation, CancellationToken cancellationToken)
    {
        await _soundEffects.Init();
        await _roundManager.Init(searchParams, userLocation, cancellationToken);

        var newRestau = await _roundManager.NextRestaurant(cancellationToken);
        vmUpdater.UpdateScore(new ScoreChangedEvent(0, 0, 0));
        vmUpdater.UpdateRestaurant(newRestau);
        _transitions?.AnimateRestaurantStart();
    }

    public async Task Answer(double guessedRating, CancellationToken cancellationToken)
    {
        _transitions?.AnimateRestaurantEnd();

        var scoreEvent = _roundManager.SaveAnswer(guessedRating);
        vmUpdater.UpdateScore(scoreEvent);
        _ = Task.Run(() => _soundEffects.PlayAnswer(correctnessPercentage: scoreEvent.RoundScore, cancellationToken), cancellationToken);

        if (_roundManager.Finished())
        {
            await RoundFinished(await _roundManager.RoundsFinished());
            return;
        }

        var newRestau = await _roundManager.NextRestaurant(cancellationToken);
        vmUpdater.UpdateRestaurant(newRestau);

        _transitions?.AnimateRestaurantStart();
    }

    public Task NextPhoto()
    {
        vmUpdater.UpdatePhoto(_roundManager.NextPhoto());
        return Task.CompletedTask;
    }

    public Task PreviousPhoto()
    {
        vmUpdater.UpdatePhoto(_roundManager.PreviousPhoto());
        return Task.CompletedTask;
    }

    public void SetTransitions(ITransitions transitions)
    {
        _transitions = transitions;
    }
}

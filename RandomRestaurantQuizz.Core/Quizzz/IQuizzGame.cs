using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizzGame
{
    Task InitRound(SearchParams searchParams, Geoloc userLocation, CancellationToken cancellationToken);
    Task Answer(double guessedRating, CancellationToken cancellationToken);
    Task NextPhoto();
    Task PreviousPhoto();
    void SetTransitions(ITransitions transitions);

    Func<RoundsFinishedEvent, Task> RoundFinished { get; set; }
}

public interface ITransitions
{
    void AnimateRestaurantEnd();
    void AnimateRestaurantStart();
}
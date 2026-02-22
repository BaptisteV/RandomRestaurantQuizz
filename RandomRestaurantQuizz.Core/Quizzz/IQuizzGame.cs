namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizzGame
{
    Task InitRound(SearchParams searchParams, SearchLocation userLocation, CancellationToken cancellationToken);
    Task Answer(double guessedRating, CancellationToken cancellationToken);
    Task NextPhoto();
    Task PreviousPhoto();

    Func<RestaurantChangedEvent, Task> RestaurantChanged { get; set; }
    Func<ScoreChangedEvent, Task> ScoreChanged { get; set; }
    Func<PhotoChangedEvent, Task> PhotoChanged { get; set; }
    Func<RoundsFinishedEvent, Task> RoundFinished { get; set; }
}
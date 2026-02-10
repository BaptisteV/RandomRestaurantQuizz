namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizzGame
{
    Task InitRound(SearchLocation searchLocation, CancellationToken cancellationToken);
    Task Answer(double guessedRating);
    Task NextPhoto();
    Task PreviousPhoto();

    Func<RestaurantChangedEvent, Task> RestaurantChanged { get; set; }
    Func<ScoreChangedEvent, Task> ScoreChanged { get; set; }
    Func<PhotoChangedEvent, Task> PhotoChanged { get; set; }
    Func<RoundsFinishedEvent, Task> RoundFinished { get; set; }
}
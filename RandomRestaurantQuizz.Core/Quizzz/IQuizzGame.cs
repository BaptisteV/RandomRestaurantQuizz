namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizzGame
{
    Task InitRound(CancellationToken cancellationToken);
    Task Answer(double guessedRating);
    Task NextPhoto();
    Task PreviousPhoto();

    Func<QuizzModel, Task> ScoreChanged { get; set; }
    Func<QuizzModel, Task> PhotoChanged { get; set; }
    Func<QuizzModel, Task> RoundFinished { get; set; }
}
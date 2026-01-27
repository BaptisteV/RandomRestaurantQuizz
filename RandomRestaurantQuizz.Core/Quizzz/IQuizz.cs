using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizz
{
    Task InitRound(CancellationToken cancellationToken);
    Task Answer(double guessedValue);
    Task NextPhoto();
    Task PreviousPhoto();

    Func<QuizzModel, Task> ScoreChanged { get; set; }
    Func<QuizzModel, Task> PhotoChanged { get; set; }
    Func<QuizzModel, Task> RoundFinished { get; set; }
}
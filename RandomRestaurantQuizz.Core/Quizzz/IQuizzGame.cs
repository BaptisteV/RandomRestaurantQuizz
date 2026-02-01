using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IEventHandler
{
    Task ScoreChanged(QuizzModel quizz);
    Task PhotoChanged(QuizzModel quizz);
    Task RoundFinished(QuizzModel quizz);
}

public interface IQuizzGame
{
    Task InitRound(CancellationToken cancellationToken);
    Task Answer(double guessedRating);
    Task NextPhoto();
    Task PreviousPhoto();
    void SetSearchLocation(GeoLoc geoloc, int radius);

    Func<QuizzModel, Task> ScoreChanged { get; set; }
    Func<QuizzModel, Task> PhotoChanged { get; set; }
    Func<QuizzModel, Task> RoundFinished { get; set; }
}
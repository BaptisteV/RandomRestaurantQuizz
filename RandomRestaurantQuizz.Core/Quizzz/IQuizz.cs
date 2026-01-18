using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizz
{
    /// <summary>
    /// Fetch data and prepare the quizz
    /// </summary>
    /// <returns></returns>
    Task DownloadRestaurants();

    Task Answer(double guessedValue);

    Task NextPhoto();
    Task PreviousPhoto();

    Func<QuizzModel, Task> ScoreChanged { get; set; }
    Func<QuizzModel, Task> PhotoChanged { get; set; }
}
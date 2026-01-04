using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizz
{
    /// <summary>
    /// Fetch data and prepare the quizz
    /// </summary>
    /// <returns></returns>
    Task Init();

    void Answer(double guessedValue);

    public QuizzModel CurrentState();
}
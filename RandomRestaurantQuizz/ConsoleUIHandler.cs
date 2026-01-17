using RandomRestaurantQuizz.Core;

namespace RandomRestaurantQuizz.Console;

internal class ConsoleUIHandler : IQuizzUIHandler
{
    public void Init(Label scoreLabel)
    {
    }

    public void OnUpdateScore(double newScore, double scoreDiff)
    {
        System.Console.WriteLine($"New score {newScore:n2}");
    }
}

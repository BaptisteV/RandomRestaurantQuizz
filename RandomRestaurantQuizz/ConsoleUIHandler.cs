using RandomRestaurantQuizz.Core;

namespace RandomRestaurantQuizz.Console;

internal class ConsoleUIHandler : IQuizzUIHandler
{
    public Task Init(Label scoreLabel)
    {
        return Task.CompletedTask;
    }

    public void OnUpdateScore(double newScore, double scoreDiff)
    {
        System.Console.WriteLine($"New score {newScore:n2}");
    }
}

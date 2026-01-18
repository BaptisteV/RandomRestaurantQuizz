namespace RandomRestaurantQuizz.Core;

public interface IQuizzUIHandler
{
    Task Init(Label scoreLabel);
    void OnUpdateScore(double newScore, double scoreDiff);
}

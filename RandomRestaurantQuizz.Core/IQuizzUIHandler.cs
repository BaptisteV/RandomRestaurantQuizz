namespace RandomRestaurantQuizz.Core;

public interface IQuizzUIHandler
{
    void Init(Label scoreLabel);
    void OnUpdateScore(double newScore, double scoreDiff);
}

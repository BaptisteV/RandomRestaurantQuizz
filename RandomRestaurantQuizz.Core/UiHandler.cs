using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.Core;

public class UiHandler(ISoundEffect soundEffects) : IQuizzUIHandler
{
    private Label _scoreLabel;

    public void Init(Label scoreLabel)
    {
        _scoreLabel = scoreLabel;
    }

    public void OnUpdateScore(double newScore, double scoreDiff)
    {
        _scoreLabel.Text = $"Score: {newScore:F2}";
        _ = Task.Run(async () => await soundEffects.PlayAnswer(correctnessPercentage: scoreDiff * 100.0, CancellationToken.None));
    }
}

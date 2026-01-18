using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.Core;

public class UiHandler(ISoundEffect soundEffects) : IQuizzUIHandler
{
    private Label _scoreLabel;

    public async Task Init(Label scoreLabel)
    {
        _scoreLabel = scoreLabel;
        await soundEffects.Init();
    }

    public void OnUpdateScore(double newScore, double scoreDiff)
    {
        _scoreLabel.Text = $"Score: {newScore:F2}";
        soundEffects.PlayAnswer(correctnessPercentage: scoreDiff * 100.0, CancellationToken.None);
    }
}

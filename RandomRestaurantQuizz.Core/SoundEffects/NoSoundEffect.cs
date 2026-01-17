namespace RandomRestaurantQuizz.Core.SoundEffects;

public class NoSoundEffect : ISoundEffect
{
    public Task Init()
    {
        return Task.CompletedTask;
    }

    public Task PlayAnswer(double correctnessPercentage, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

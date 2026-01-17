namespace RandomRestaurantQuizz.Core.SoundEffects;

public interface ISoundEffect
{
    Task Init();
    Task PlayAnswer(double correctnessPercentage, CancellationToken cancellationToken);
}
namespace RandomRestaurantQuizz.Core.SoundEffects
{
    public interface ISoundEffect
    {
        Task Init();
        Task OnAnswer(double correctnessPercentage, CancellationToken cancellationToken);
    }
}
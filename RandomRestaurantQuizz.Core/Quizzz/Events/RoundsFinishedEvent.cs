namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class RoundsFinishedEvent
{
    public RoundsFinishedEvent(double totalScore, List<Score> pbs)
    {
        TotalScore = totalScore;
        PersonalBests = pbs;
    }

    public double TotalScore { get; }
    public List<Score> PersonalBests { get; }
}

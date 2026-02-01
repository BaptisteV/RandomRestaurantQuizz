using RandomRestaurantQuizz.Core.Quizzz.Scores;

namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class RoundFinishedEvent
{
    public RoundFinishedEvent(double totalScore, List<Score> pbs)
    {
        TotalScore = totalScore;
        PersonalBests = pbs;
    }

    public double TotalScore { get; }
    public List<Score> PersonalBests { get; }
}

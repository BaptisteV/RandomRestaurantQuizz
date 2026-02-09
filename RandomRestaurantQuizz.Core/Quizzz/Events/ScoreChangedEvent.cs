namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class ScoreChangedEvent
{
    public ScoreChangedEvent(double totalScore, double roundScore, double locationRating)
    {
        TotalScore = $"{totalScore:F2}";
        RoundScore = roundScore;
        ScoreDiff = $" +{roundScore} ({locationRating:F2})";
    }
    public string TotalScore { get; }
    public double RoundScore { get; }
    public string ScoreDiff { get; }
}

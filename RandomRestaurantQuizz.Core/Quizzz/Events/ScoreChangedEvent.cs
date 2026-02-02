namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class ScoreChangedEvent
{
    public ScoreChangedEvent(int totalScore, double roundScore, double locationRating)
    {
        TotalScore = totalScore;
        RoundScore = roundScore;
        ScoreDiff = $" +{roundScore} ({locationRating:n1})";
    }
    public int TotalScore { get; }
    public double RoundScore { get; }
    public string ScoreDiff { get; }
}

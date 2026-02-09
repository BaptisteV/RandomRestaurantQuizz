namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class ScoreChangedEvent
{
    public ScoreChangedEvent(double totalScore, double roundScore, double locationRating)
    {
        TotalScore = totalScore;
        RoundScore = roundScore;
        ScoreDiff = $" +{roundScore} ({locationRating:n1})";
    }
    public double TotalScore { get; }
    public double RoundScore { get; }
    public string ScoreDiff { get; }
}

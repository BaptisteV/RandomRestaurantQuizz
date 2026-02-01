namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class ScoreChangedEvent
{
    public ScoreChangedEvent(int totalScore, double roundScore, string locationName, int userRatingCount, double locationRating, bool fromAnswer)
    {
        TotalScore = totalScore;
        RoundScore = roundScore;
        LocationLabel = $"{locationName} ({userRatingCount} 👤)";
        ScoreDiff = $" +{roundScore} ({locationRating:n1})";
        FromAnswer = fromAnswer;
    }
    public int TotalScore { get; }
    public double RoundScore { get; }
    public string LocationLabel { get; }
    public string ScoreDiff { get; }
    public bool FromAnswer { get; }
}

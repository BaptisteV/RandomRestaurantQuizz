namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class Score
{
    public int Id { get; set; }
    public double Value { get; init; }
    public DateTime Timestamp { get; init; }
}

public static class ScoresExtensions
{
    extension(IEnumerable<Score> scores)
    {
        public IEnumerable<Score> SortBest()
        {
            return scores
                .OrderByDescending(s => s.Value)
                .ThenByDescending(s => s.Timestamp);
        }
    }
}
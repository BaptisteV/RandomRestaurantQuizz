namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class Score
{
    public required double Value { get; init; }
    public required DateTime Timestamp { get; init; }
    public required string LocationName { get; init; }
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
namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IScoreSaver
{
    Task<List<Score>> ReadScores();
    Task SaveScore(int roundScore);
}

public class Score
{
    public int Value { get; init; }
    public DateTime Timestamp { get; init; }
}

public class TempScoreSaver : IScoreSaver
{
    private const int MaxScoreCount = 2;
    private List<Score> _scores = [];

    public Task<List<Score>> ReadScores()
    {
        _scores = [.. _scores.Take(MaxScoreCount)];
        return Task.FromResult(_scores);
    }

    public Task SaveScore(int roundScore)
    {
        _scores.Add(new Score { Value = roundScore, Timestamp = DateTime.UtcNow });
        return Task.CompletedTask;
    }
}

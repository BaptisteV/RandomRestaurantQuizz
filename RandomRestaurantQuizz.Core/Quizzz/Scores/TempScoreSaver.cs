namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class TempScoreSaver : IScoreSaver
{
    private readonly List<Score> _scores = [];

    public Task Init()
    {
        return Task.CompletedTask;
    }

    public Task<List<Score>> ReadScores()
    {
        return Task.FromResult(_scores);
    }

    public Task SaveScore(Score score)
    {
        _scores.Add(score);
        return Task.CompletedTask;
    }
}

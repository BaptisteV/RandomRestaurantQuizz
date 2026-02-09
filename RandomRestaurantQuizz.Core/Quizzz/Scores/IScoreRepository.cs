namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public interface IScoreRepository
{
    Task Init();
    Task<List<Score>> ReadScores();
    Task SaveScore(Score score);
}

namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public interface IScoreSaver
{
    Task Init();
    Task<List<Score>> ReadScores();
    Task SaveScore(Score score);
}

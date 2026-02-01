namespace RandomRestaurantQuizz.App.ViewModels;

public class RecapViewModel
{
    public RecapViewModel(double totalScore, List<Score> personalBests)
    {
        TotalScore = totalScore;
        Scores = personalBests;
        ScoreText = $"Score: {TotalScore:n1}";
    }
    public double TotalScore { get; }
    public string ScoreText { get; }
    public List<Score> Scores { get; }
}
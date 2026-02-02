using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class VmScore : ObservableObject
{
    [ObservableProperty]
    public partial string Timestamp { get; set; }

    [ObservableProperty]
    public partial double Value { get; set; }
}

public partial class RecapViewModel : ObservableObject
{
    public RecapViewModel(double totalScore, List<Score> scores)
    {
        TotalScore = totalScore;
        var vmScores = scores.ConvertAll<VmScore>(s => new VmScore()
        {
            Timestamp = s.Timestamp.ToString("G"),
            Value = s.Value,
        });
        Scores = new(vmScores);
        ScoreText = $"Score: {TotalScore:n1}";
    }

    [ObservableProperty]
    public partial double TotalScore { get; set; }
    [ObservableProperty]
    public partial string ScoreText { get; set; }
    [ObservableProperty]
    public partial ObservableCollection<VmScore> Scores { get; set; }
}
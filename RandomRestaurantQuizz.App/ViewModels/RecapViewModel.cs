using CommunityToolkit.Mvvm.ComponentModel;
using RandomRestaurantQuizz.App.Resources.Strings;
using System.Collections.ObjectModel;
namespace RandomRestaurantQuizz.App.ViewModels;

public partial class VmScore : ObservableObject
{
    [ObservableProperty]
    public partial string Timestamp { get; set; }

    [ObservableProperty]
    public partial double Value { get; set; }

    [ObservableProperty]
    public partial string LocationName { get; set; }
}

public partial class RecapViewModel : ObservableObject
{
    public RecapViewModel(double totalScore, List<Score> scores)
    {
        TotalScore = totalScore;
        var vmScores = scores.ConvertAll(s => new VmScore()
        {
            Timestamp = s.Timestamp.ToString("G"),
            Value = s.Value,
            LocationName = s.LocationName,
        });
        Scores = new(vmScores);
        ScoreText = $"{AppText.ScoreHeader}{TotalScore:F2}";
    }

    [ObservableProperty]
    public partial double TotalScore { get; set; }
    [ObservableProperty]
    public partial string ScoreText { get; set; }
    [ObservableProperty]
    public partial ObservableCollection<VmScore> Scores { get; set; }
}
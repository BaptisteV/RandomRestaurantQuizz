using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RandomRestaurantQuizz.App.Pages.MainPage;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial bool IsLoading { get; set; } = true;
    [ObservableProperty]
    public partial VmSearchLocation SearchLocation { get; set; } = new();
    [ObservableProperty]
    public partial VmRound Round { get; set; } = new();
    [ObservableProperty]
    public partial string Score { get; set; } = $"{0.0:F2}";
    [ObservableProperty]
    public partial string ScoreDiff { get; set; } = $" +{0.0:F2} ({0.0:F2})";
    [ObservableProperty]
    public partial ImageSource? ImageSource { get; set; }
    [ObservableProperty]
    public partial double RatingInput { get; set; } = 2.5;
    [ObservableProperty]
    public partial string RatingInputText { get; set; } = $"{2.5:F2}";

    [ObservableProperty]
    public partial ObservableCollection<VmReview> Reviews { get; set; } = new();

    public ICommand ToggleReviewCommand => new RelayCommand<VmReview>(review =>
    {
        if (review == null) return;
        foreach (var r in Reviews)
        {
            r.IsExpanded = (r == review) && !r.IsExpanded;
        }
        review.Text = review.IsExpanded ? review.FullText : review.TruncatedText;
    });
}

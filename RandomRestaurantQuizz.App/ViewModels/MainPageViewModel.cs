using CommunityToolkit.Mvvm.ComponentModel;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial int Score { get; set; }

    [ObservableProperty]
    public partial string ScoreDiff { get; set; }

    [ObservableProperty]
    public partial string LocationName { get; set; }

    [ObservableProperty]
    public partial ImageSource ImageSource { get; set; }
}

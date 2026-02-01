using CommunityToolkit.Mvvm.ComponentModel;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial string LocationName { get; set; }

    [ObservableProperty]
    public partial int Score { get; set; }

    [ObservableProperty]
    public partial string ScoreDiff { get; set; }

    [ObservableProperty]
    public partial string RestaurantName { get; set; }

    [ObservableProperty]
    public partial ImageSource ImageSource { get; set; }

    [ObservableProperty]
    public partial List<Review> Reviews { get; set; }
}

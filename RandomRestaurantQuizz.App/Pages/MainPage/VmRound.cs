using CommunityToolkit.Mvvm.ComponentModel;

namespace RandomRestaurantQuizz.App.Pages.MainPage;

public partial class VmRound : ObservableObject
{
    [ObservableProperty]
    public partial string RestaurantName { get; set; } = "";
    [ObservableProperty]
    public partial string Progress { get; set; } = "";
}

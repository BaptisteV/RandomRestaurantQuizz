using CommunityToolkit.Mvvm.ComponentModel;

namespace RandomRestaurantQuizz.App.Pages.MainPage;

public partial class VmSearchLocation : ObservableObject
{
    [ObservableProperty]
    public partial string Name { get; set; } = "";
    [ObservableProperty]
    public partial double Latitude { get; set; }
    [ObservableProperty]
    public partial double Longitude { get; set; }
}

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class GeoLocPickerViewModel : ObservableObject
{
    [ObservableProperty]
    public partial bool Enabled { get; set; } = false;
    [ObservableProperty]
    public partial ObservableCollection<string> GeoLocations { get; set; } = [];
}

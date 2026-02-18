using RandomRestaurantQuizz.App.Resources.Strings;
using RandomRestaurantQuizz.App.Services;
namespace RandomRestaurantQuizz.App;

public partial class GeoLocPickerPage : ContentPage
{
    private readonly GeoLocPickerViewModel _vm;
    private readonly IGeolocationService _geoService;
    private readonly ILogger<GeoLocPickerPage> _logger;

    private static readonly string AroundMe = $"📌 {AppText.AroundMe} 📌";

    public Func<SearchLocation, Task> SearchLocationChanged { get; set; } = (_) => Task.CompletedTask;

    public GeoLocPickerPage(GeoLocPickerViewModel vm, IGeolocationService geoService, ILogger<GeoLocPickerPage> logger)
    {
        _vm = vm;
        _geoService = geoService;
        _logger = logger;

        BindingContext = _vm;
        InitializeComponent();
        CreateLocationButtons();
    }

    private void CreateLocationButtons()
    {
        _vm.Locations.Add(AroundMe);
        var cities = Locations.Cities.Select(c => c.Name).Order();
        foreach (var city in cities)
        {
            _vm.Locations.Add(city);
        }
    }

    private async void Btn_Clicked(object? sender, EventArgs e)
    {
        var btn = (Button)sender!;
        var city = btn.Text;
        _logger.LogInformation("Picked {City}", city);

        SearchLocation search;
        if (city == AroundMe)
        {
            search = await _geoService.GetCurrentLocation();
            await SearchLocationChanged(search);
        }
        else
        {
            search = Locations.Cities.Single(l => l.Name == city);
            await SearchLocationChanged(search);
        }

        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
    }
}
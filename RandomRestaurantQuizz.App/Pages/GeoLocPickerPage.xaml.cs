using RandomRestaurantQuizz.App.Resources.Strings;
namespace RandomRestaurantQuizz.App;

public partial class GeoLocPickerPage : ContentPage
{
    private readonly GeoLocPickerViewModel _vm;
    private readonly IGeolocationService _geoService;
    private readonly VmUpdater _vmUpdater;
    private Geoloc _userGeoloc = new();
    private bool firstLoad = true;

    private readonly ILogger<GeoLocPickerPage> _logger;

    private static readonly string AroundMe = $"📌 {AppText.AroundMe} 📌";

    public GeoLocPickerPage(
        GeoLocPickerViewModel vm,
        IGeolocationService geoService,
        VmUpdater vmUpdater,
        ILogger<GeoLocPickerPage> logger)
    {
        _vm = vm;
        _geoService = geoService;
        _vmUpdater = vmUpdater;
        _logger = logger;
        _vm.GeoLocations = new(Locations.Cities.Select(c => "").Append(""));
        BindingContext = _vm;
        InitializeComponent();
    }

    private void SetLocationButtons()
    {
        var cities = Locations.Cities.OrderByDistance(_userGeoloc).Select(c => c.Location.Name).ToArray();
        _vm.GeoLocations[0] = AroundMe;
        for (var i = 0; i < cities.Length; i++)
        {
            _vm.GeoLocations[i + 1] = cities[i];
        }
        _vm.Enabled = true;
    }

    private async void Btn_Clicked(object? sender, EventArgs e)
    {
        var btn = (Button)sender!;
        var city = btn.Text;
        _logger.LogInformation("Picked {City}", city);

        if (city == AroundMe)
        {
            _vmUpdater.UpdateSearchLocation(new SearchLocation() { Geoloc = _userGeoloc });
        }
        else
        {
            var search = Locations.Cities.Find(city);
            _vmUpdater.UpdateSearchLocation(search);
        }

        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
    }

    private async void ContentPage_Loaded(object? sender, EventArgs e)
    {
        if (firstLoad)
        {
            _userGeoloc = await _geoService.GetCurrentLocation();
            SetLocationButtons();
        }
        firstLoad = false;
    }
}
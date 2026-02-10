namespace RandomRestaurantQuizz.App;

public partial class GeoLocPickerPage : ContentPage
{
    private readonly GeoLocPickerViewModel _vm;
    private readonly IGeolocationService _geoService;
    private readonly ILogger<GeoLocPickerPage> _logger;

    private const string AroundMe = "🚩 Around me 🚩";

    public Func<string, SearchLocation, Task> SearchLocationChanged { get; set; } = (_, _) => Task.CompletedTask;

    public GeoLocPickerPage(GeoLocPickerViewModel vm, IGeolocationService geoService, ILogger<GeoLocPickerPage> logger)
    {
        _vm = vm;
        _geoService = geoService;
        BindingContext = _vm;
        _logger = logger;
        InitializeComponent();

        _vm.Cities.Add(AroundMe);
        var cities = Cities.Data.Keys;
        foreach (var city in cities.Order())
        {
            _vm.Cities.Add(city);
        }
    }

    private async void Btn_Clicked(object? sender, EventArgs e)
    {
        var btn = (Button)sender!;
        var city = btn.Text;
        _logger.LogInformation("Picked {City}", city);

        SearchLocation geoloc;
        if (city == AroundMe)
        {
            geoloc = await _geoService.GetCurrentLocation();
            await SearchLocationChanged(city, geoloc);
        }
        else
        {
            geoloc = Cities.Data[city];
            await SearchLocationChanged(city, geoloc);
        }

        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
    }

    //private Button FakeBtnDijon = new Button { Text = "Dijon" };
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
#if DEBUG
        //Btn_Clicked(FakeBtnDijon, EventArgs.Empty);
#endif
    }
}
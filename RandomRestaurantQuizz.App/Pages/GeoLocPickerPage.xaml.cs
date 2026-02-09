namespace RandomRestaurantQuizz.App;

public partial class GeoLocPickerPage : ContentPage
{
    private readonly GeoLocPickerViewModel _vm;
    private readonly ILogger<GeoLocPickerPage> _logger;
    public (string Name, GeoLoc Geoloc) CurrentLocation;

    public Func<string, GeoLoc, Task> SearchLocationChanged { get; set; } = (_, _) => Task.CompletedTask;

    public GeoLocPickerPage(GeoLocPickerViewModel vm, ILogger<GeoLocPickerPage> logger)
    {
        _vm = vm;
        BindingContext = _vm;
        _logger = logger;
        InitializeComponent();

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

        var geoloc = Cities.Data[city];
        CurrentLocation = (city, geoloc);
        await SearchLocationChanged(city, geoloc);
        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
    }

    private Button FakeBtnDijon = new Button { Text = "Dijon" };
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        // TODO Only for debugging
#if DEBUG
        Btn_Clicked(FakeBtnDijon, EventArgs.Empty);
#endif
    }
}
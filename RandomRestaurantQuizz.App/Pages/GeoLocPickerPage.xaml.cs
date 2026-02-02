namespace RandomRestaurantQuizz.App;

public partial class GeoLocPickerPage : ContentPage
{
    private readonly ILogger<GeoLocPickerPage> _logger;
    public (string Name, GeoLoc Geoloc) CurrentLocation;

    public Func<string, GeoLoc, Task> SearchLocationChanged { get; set; } = (_, _) => Task.CompletedTask;

    public GeoLocPickerPage(ILogger<GeoLocPickerPage> logger)
    {
        _logger = logger;
        InitializeComponent();

        var cities = Cities.Data.Keys;
        foreach (var city in cities.Order())
        {
            var btn = new Button()
            {
                Text = city,
                IsEnabled = true,
            };
            btn.Clicked += Btn_Clicked;
            BtnContainer.Add(btn);
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
}
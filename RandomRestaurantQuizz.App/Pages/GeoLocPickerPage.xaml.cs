using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.App;

public partial class GeoLocPickerPage : ContentPage
{
    private readonly ILogger _logger;

    public Func<string, GeoLoc, Task> NewLocation { get; set; } = (_, _) => Task.CompletedTask;
    public GeoLocPickerPage(ILogger logger)
    {
        InitializeComponent();
        var cities = Cities.Data.Keys;
        foreach (var city in cities)
        {
            var btn = new Button()
            {
                Text = city,
                IsEnabled = true,
            };
            btn.Clicked += Btn_Clicked;
            BtnContainer.Add(btn);
        }

        _logger = logger;
    }

    private async void Btn_Clicked(object? sender, EventArgs e)
    {
        var btn = (Button)sender!;
        var city = btn.Text;
        _logger.LogInformation("Picked {City}", city);

        var geoloc = Cities.Data[city];
        await NewLocation(city, geoloc);
        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
    }
}
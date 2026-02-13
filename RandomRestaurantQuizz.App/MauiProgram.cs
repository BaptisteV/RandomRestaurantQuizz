using RandomRestaurantQuizz.App.Services;

namespace RandomRestaurantQuizz.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Logging.AddDebug();
        builder.Logging.SetMinimumLevel(LogLevel.Information);
#if DEBUG
        builder.Logging.SetMinimumLevel(LogLevel.Debug);
#endif
        builder.Configuration.AddSecretsFromRessources();
        builder.Services.AddCoreServices();

        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<RecapViewModel>();
        builder.Services.AddSingleton<GeoLocPickerViewModel>();
        builder.Services.AddSingleton<GeoLocPickerPage>();
        builder.Services.AddTransient<IGeolocationService, GeolocationService>();
        builder.Services.AddTransient((_) => new AppDataDb() { DbFile = Path.Combine(FileSystem.AppDataDirectory, "scores.db") });

        return builder.Build();
    }
}

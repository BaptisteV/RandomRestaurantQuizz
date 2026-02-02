using RandomRestaurantQuizz.Core;

namespace RandomRestaurantQuizz.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
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
        builder.Services.AddCoreServices();

        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<RecapViewModel>();
        builder.Services.AddSingleton<GeoLocPickerViewModel>();
        builder.Services.AddSingleton<GeoLocPickerPage>();

        AppDomain.CurrentDomain.UnhandledException += (s, e) =>
        {
            var ex = e.ExceptionObject as Exception;
            System.Diagnostics.Debug.WriteLine("AppDomain exception: " + ex);
        };

        TaskScheduler.UnobservedTaskException += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine("Unobserved task exception: " + e.Exception);
            e.SetObserved();
        };

        return builder.Build();
    }
}

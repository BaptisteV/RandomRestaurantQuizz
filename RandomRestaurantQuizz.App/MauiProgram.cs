using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.App.ViewModels;
using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Quizzz;

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

        builder.Services.AddSingleton<IQuizzViewModel, MainPageViewModel>();

        AppDomain.CurrentDomain.UnhandledException += (s, e) =>
        {
            var ex = e.ExceptionObject as Exception;
            System.Diagnostics.Debug.WriteLine("AppDomain exception: " + ex);
        };

        TaskScheduler.UnobservedTaskException += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine("Unobserved task exception: " + e.Exception);
            e.SetObserved(); // prevents process termination in some scenarios
        };

        return builder.Build();
    }
}

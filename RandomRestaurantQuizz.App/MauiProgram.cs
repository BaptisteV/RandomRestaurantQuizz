using RandomRestaurantQuizz.App.Pages.Transitions;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.SoundEffects;

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
                fonts.AddFont("Typewriter-Monospace.ttf", "TypewriterMonospace");
            });

        builder.Logging.AddDebug();
        builder.Logging.SetMinimumLevel(LogLevel.Information);
#if DEBUG
        builder.Logging.SetMinimumLevel(LogLevel.Debug);
#endif
        builder.Configuration.AddSecrets();
        builder.Configuration.AddAppsettings();

        builder.Services.AddCoreServices();

        builder.Services.AddHttpClient<IQuizzApiClient, QuizzApiClient>();
        builder.Services.AddHttpClient<IPhotoDownloader, PhotoDownloader>();

        builder.Services.AddTransient<IFileNamer, FileNamer>();

        builder.Services.AddSingleton(Plugin.Maui.Audio.AudioManager.Current);
        builder.Services.AddSingleton<ISoundEffect, ResourceSoundEffect>();
        builder.Services.AddSingleton<IScoreRepository, SqliteScoreRepository>();
        builder.Services.AddSingleton<RoundManager>();

        builder.Services.AddSingleton<VmUpdater>();
        builder.Services.AddSingleton<ITransitions, MainPageTransitions>();
        builder.Services.AddSingleton<IQuizzGame, Game2>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<RecapViewModel>();
        builder.Services.AddSingleton<GeoLocPickerViewModel>();
        builder.Services.AddSingleton<GeoLocPickerPage>();
        builder.Services.AddSingleton<IGeolocationService, GeolocationService>();
        builder.Services.AddTransient((_) => new AppDataDb() { DbFile = Path.Combine(FileSystem.AppDataDirectory, "scores.db") });

        return builder.Build();
    }
}

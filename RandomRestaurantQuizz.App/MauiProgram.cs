using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.SoundEffects;
using System.Reflection;

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

#if DEBUG
        builder.Logging.AddDebug();
        builder.Logging.SetMinimumLevel(LogLevel.Debug);
#endif
        var services = builder.Services;
        services.AddHttpClient<IGooglePlacesClient, GooglePlacesClient>();
        // Load embedded JSON config
        using var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream($"{typeof(MauiProgram).Namespace}.secrets.json")
                ?? throw new InvalidOperationException("Failed to load embedded configuration file.");

        var secrets = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();

        var apiKey = secrets.GetRequiredSection("GOOGLE_PLACES_API_KEY").Value;

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException("GOOGLE_PLACES_API_KEY not found");
        }

        services.AddHttpClient<IGooglePlacesClient, GooglePlacesClient>(a =>
        {
            a.BaseAddress = new Uri("https://places.googleapis.com/v1/places:searchNearby");
        });

        services.Configure<SecretsJson>(c =>
        {
            c.GooglePlacesApiKey = apiKey;
        });

        services.AddTransient<IFileNamer, FileNamer>();
        services.AddTransient<PhotoFileManager>();
        services.AddTransient(provider =>
        {
            var httpClient = provider.GetRequiredService<HttpClient>();
            return new PhotoDownloader(httpClient, apiKey, provider.GetRequiredService<IFileNamer>(), provider.GetRequiredService<ILogger<PhotoDownloader>>());
        });

        services.AddTransient<IPlaceFinder, PlaceFinder>();
        services.AddSingleton(Plugin.Maui.Audio.AudioManager.Current);
        // services.AddSingleton<ISoundEffect, ResourceSoundEffect>();
        services.AddSingleton<ISoundEffect, SoundEffectGenerator>();
        services.AddSingleton<IQuizz, Quizz>();

        return builder.Build();
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Quizzz;
using System.Reflection;
using System.Text.Json.Serialization;

namespace RandomRestaurantQuizz.App;

public class SecretsJson
{
    [JsonPropertyName("GOOGLE_PLACES_API_KEY")]
    public string GooglePlacesApiKey { get; set; } = "";
}

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
#endif
        var services = builder.Services;
        services.AddHttpClient();
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

        services.AddSingleton(provider =>
        {
            var httpClient = provider.GetRequiredService<HttpClient>();
            return new GooglePlacesClient(httpClient, apiKey, provider.GetRequiredService<ILogger<GooglePlacesClient>>());
        });

        services.AddTransient<IFileNamer, FileNamer>();
        services.AddTransient<PhotoFileManager>();
        services.AddTransient(provider =>
        {
            var httpClient = provider.GetRequiredService<HttpClient>();
            return new PhotoDownloader(httpClient, apiKey, provider.GetRequiredService<IFileNamer>(), provider.GetRequiredService<ILogger<PhotoDownloader>>());
        });

        services.AddTransient<IPlaceFinder, PlaceFinder>();
        services.AddSingleton<IQuizz, Quizz>();
        services.AddSingleton(Plugin.Maui.Audio.AudioManager.Current);
        services.AddTransient<RessourSoundEffect>();

        return builder.Build();
    }
}

using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
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

#if DEBUG
        builder.Logging.AddDebug();
#endif
        var services = builder.Services;
        services.AddHttpClient();

        var apiKey = Environment.GetEnvironmentVariable("GOOGLE_PLACES_API_KEY") ?? "AIzaSyBujm_BrN3VEi8k4vfUoX3-vcwfZ37R2K0";
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException("GOOGLE_PLACES_API_KEY environment variable is not set.");
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
        services.AddTransient<IQuizz, Quizz>();
        return builder.Build();
    }
}

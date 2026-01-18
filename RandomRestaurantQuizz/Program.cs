using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Console;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.SoundEffects;

Console.WriteLine("Starting...");
await Host.CreateDefaultBuilder(args)
    .ConfigureLogging(logging =>
    {
        logging.AddSimpleConsole(options =>
        {
            options.IncludeScopes = false;
            options.SingleLine = true;
            options.TimestampFormat = "[HH:mm:ss:fff] ";
        });
        logging.SetMinimumLevel(LogLevel.Information);
    })
    .ConfigureServices((context, services) =>
    {
        var apiKey = Environment.GetEnvironmentVariable("GOOGLE_PLACES_API_KEY");
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException("GOOGLE_PLACES_API_KEY environment variable is not set.");
        }

        services.AddHttpClient<IGooglePlacesClient, GooglePlacesClient>(a =>
        {
            a.BaseAddress = new Uri("https://places.googleapis.com/v1/places:searchNearby");
        });

        services.AddHttpClient<IPhotoDownloader, PhotoDownloader>();

        services.Configure<SecretsJson>(c =>
        {
            c.GooglePlacesApiKey = apiKey;
        });

        services.AddTransient<IFileNamer, FileNamer>();
        services.AddTransient<PhotoFileManager>();
        services.AddTransient<IRunner, QuizzConsoleRunner>();
        services.AddSingleton(Plugin.Maui.Audio.AudioManager.Current);
        services.AddSingleton<ISoundEffect, SoundEffectGenerator>();
        services.AddTransient<IQuizz, Quizz>();
    })
    .UseDefaultServiceProvider(o =>
    {
        o.ValidateScopes = true;
        o.ValidateOnBuild = true;
    })
    .Build()
    .Services
    .GetRequiredService<IRunner>()
    .RunAsync();


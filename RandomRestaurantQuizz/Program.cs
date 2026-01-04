using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz;

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
        // Register HttpClient
        services.AddHttpClient();

        var apiKey = Environment.GetEnvironmentVariable("GOOGLE_PLACES_API_KEY");
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException("GOOGLE_PLACES_API_KEY environment variable is not set.");
        }

        // Register GooglePlacesClient as singleton
        services.AddSingleton<GooglePlacesClient>(provider =>
        {
            var httpClient = provider.GetRequiredService<HttpClient>();
            return new GooglePlacesClient(httpClient, apiKey, provider.GetRequiredService<ILogger<GooglePlacesClient>>());
        });

        // Register GooglePlacesClient as singleton
        services.AddSingleton<PhotoManager>(provider =>
        {
            var httpClient = provider.GetRequiredService<HttpClient>();
            return new PhotoManager(httpClient, apiKey, provider.GetRequiredService<ILogger<PhotoManager>>());
        });

        // Register your application runner
        services.AddTransient<App>();
    })
    .Build()
    .Services
    .GetRequiredService<App>()
    .RunAsync();


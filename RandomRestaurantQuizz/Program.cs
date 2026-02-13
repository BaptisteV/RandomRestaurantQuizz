using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Quizzz.Scores;

namespace RandomRestaurantQuizz.Console;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        System.Console.WriteLine("Starting...");

        var builder = Host.CreateDefaultBuilder(args)
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
                services.AddCoreServices();
                services.AddTransient((_) => new AppDataDb() { DbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "scores.db") });
                services.AddSingleton<IRunner, QuizzConsoleRunner>();
            })
            .UseDefaultServiceProvider(o =>
            {
                o.ValidateScopes = true;
                o.ValidateOnBuild = true;
            });

        var host = builder.Build();

        var runner = host.Services.GetRequiredService<IRunner>();
        await runner.RunAsync(CancellationToken.None);
    }
}
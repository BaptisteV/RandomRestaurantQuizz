using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core;

namespace RandomRestaurantQuizz.Console;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        System.Console.WriteLine("Starting...");
        var host = Host.CreateDefaultBuilder(args)
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
                services.AddSingleton<IRunner, QuizzConsoleRunner>();
            })
            .UseDefaultServiceProvider(o =>
            {
                o.ValidateScopes = true;
                o.ValidateOnBuild = true;
            })
            .Build();

        await host.Services.GetRequiredService<IRunner>().RunAsync(CancellationToken.None);
    }
}
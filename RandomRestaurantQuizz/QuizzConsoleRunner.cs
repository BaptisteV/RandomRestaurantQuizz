using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Quizzz;
using System.Globalization;

namespace RandomRestaurantQuizz.Console;

public class QuizzConsoleRunner : IRunner
{
    private readonly IQuizzGame _quizzGame;
    private readonly ILogger<QuizzConsoleRunner> _logger;
    private const string CityName = "Dijon";

    public QuizzConsoleRunner(IQuizzGame quizz, ILogger<QuizzConsoleRunner> logger)
    {
        _quizzGame = quizz;
        _logger = logger;
        _quizzGame.PhotoChanged = LogEvent;
        _quizzGame.ScoreChanged = LogEvent;
        _quizzGame.RoundFinished = LogEvent;
    }

    private Task LogEvent(object evt)
    {
        var t = evt.GetType().Name;
        _logger.LogInformation("Event: {EventType}", t);
        return Task.CompletedTask;
    }

#pragma warning disable S2190 // Add a way to break out this method's recursion
    public async Task RunAsync(CancellationToken cancellationToken)
    {
        Cities.Data.TryGetValue(CityName, out var city);
        await _quizzGame.InitRound((Name: CityName, Geoloc: city), cancellationToken);
        while (true)
        {
            var answerValue = DoubleReader.ReadDouble("Guessed rating ? : ");
            await _quizzGame.Answer(answerValue);
        }
    }
#pragma warning restore S2190 // Add a way to break out this method's recursion
}

public static class DoubleReader
{
    public static double ReadDouble(string prompt = "Enter a number: ")
    {
        while (true)
        {
            System.Console.Write(prompt);
            string? input = System.Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (double.TryParse(
                    input.Trim().Replace(',', '.'),
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    CultureInfo.InvariantCulture,
                    out double result))
            {
                return result;
            }

            System.Console.WriteLine("Invalid number. Please try again.");
        }
    }
}
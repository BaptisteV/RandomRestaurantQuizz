using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Quizzz;
using System.Globalization;

namespace RandomRestaurantQuizz.Console;

public class QuizzConsoleRunner : IRunner
{
    private readonly IQuizz _quizz;
    private readonly ILogger<QuizzConsoleRunner> _logger;

    public QuizzConsoleRunner(IQuizz quizz, ILogger<QuizzConsoleRunner> logger)
    {
        _quizz = quizz;
        _logger = logger;
        _quizz.ScoreChanged = async (model) =>
        {
            _logger.LogInformation("{CurrentState}", model);
        };
    }

    public async Task RunAsync()
    {
        await _quizz.DownloadRestaurants();
        while (true)
        {
            var answerValue = DoubleReader.ReadDouble("Guessed rating ? : ");
            await _quizz.Answer(answerValue);
        }
    }
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

            // Normalize decimal separator
            input = input.Trim().Replace(',', '.');

            if (double.TryParse(
                    input,
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
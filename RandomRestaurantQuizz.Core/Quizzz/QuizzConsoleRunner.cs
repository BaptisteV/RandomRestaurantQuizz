using Microsoft.Extensions.Logging;
using System.Globalization;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class QuizzConsoleRunner : IRunner
{
    private readonly IQuizz _quizz;
    private readonly ILogger<QuizzConsoleRunner> _logger;

    public QuizzConsoleRunner(IQuizz quizz, ILogger<QuizzConsoleRunner> logger)
    {
        _quizz = quizz;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        await _quizz.Init();
        while (true)
        {
            _logger.LogInformation("{CurrentState}", _quizz.CurrentState());
            var answerValue = DoubleReader.ReadDouble("Guessed rating ? : ");
            _quizz.Answer(answerValue);
        }
    }
}

public static class DoubleReader
{
    public static double ReadDouble(string prompt = "Enter a number: ")
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

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

            Console.WriteLine("Invalid number. Please try again.");
        }
    }
}
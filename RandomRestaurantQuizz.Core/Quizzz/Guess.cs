using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Guess
{
    public required PlaceResult Place { get; set; }
    public required double GuessedScore { get; set; }

    public double ScoreDiffPercentage()
    {
        return Math.Abs(GuessedScore - Place.Rating ?? 0.0) * 100.0;
    }
}

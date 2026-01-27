using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Guess
{
    public required PlaceResult Place { get; set; }
    public required double GuessedRating { get; set; }

    public double RoundScore()
    {
        var score = 0.0;
        var dist = Math.Abs(GuessedRating - (Place.Rating ?? 0));
        if (dist <= 1.5)
        {
            // Linear scaling: 0 distance = 100 points, 1.5 distance = 0 points
            score = Math.Round(100 * (1 - dist / 1.5));
        }
        return score;
    }
}

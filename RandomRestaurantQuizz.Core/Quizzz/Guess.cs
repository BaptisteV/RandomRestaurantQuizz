using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Guess(PlaceResult place, double guessedRating)
{
    public PlaceResult Place { get; } = place;
    public double GuessedRating { get; } = guessedRating;

    public double RoundScore()
    {
        var score = 0.0;
        var dist = Math.Abs(GuessedRating - Place.Rating);
        if (dist <= 1.5)
        {
            // Linear scaling: 0 distance = 100 points, 1.5 distance = 0 points
            score = Math.Round(100 * (1 - dist / 1.5), 2);
        }
        return score;
    }
}

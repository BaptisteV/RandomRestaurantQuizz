namespace RandomRestaurantQuizz.Quizzz;

public class Player
{
    public List<Guess> Guesses { get; set; } = [];
    public double Score()
    {
        var score = 0.0;
        foreach (var guess in Guesses)
        {
            var dist = Math.Abs(guess.GuessedScore - (guess.Place.Rating ?? 0));
            if (dist < 2.0)
            {
                score += dist;
            }
        }
        return score;
    }
}

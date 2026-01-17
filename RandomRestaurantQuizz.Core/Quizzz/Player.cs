using System.Collections.ObjectModel;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Player
{
    public ObservableCollection<Guess> Guesss { get; set; } = [];
    //private List<Guess> Guesses { get; set; } = [];

    public void NewGuess(Guess guess)
    {
        Guesss.Add(guess);
    }

    public double Score()
    {
        var score = 0.0;
        foreach (var guess in Guesss)
        {
            var dist = Math.Abs(guess.GuessedScore - (guess.Place.Rating ?? 0));

            if (dist <= 1.5)
            {
                // Linear scaling: 0 distance = 100 points, 1.5 distance = 0 points
                score += 100 * (1 - dist / 1.5);
                score = Math.Round(score, 2);
            }
        }
        return score;
    }
}

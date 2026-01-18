namespace RandomRestaurantQuizz.Core.Quizzz;

public class Player
{
    private readonly List<Guess> _guesses = [];

    public void NewGuess(Guess guess)
    {
        _guesses.Add(guess);
    }

    public double TotalScore()
    {
        var score = 0.0;
        foreach (var guess in _guesses)
        {
            score += guess.GuessScore();
        }
        return score;
    }
}

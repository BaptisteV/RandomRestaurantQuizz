namespace RandomRestaurantQuizz.Core.Quizzz;

public class Player
{
    private readonly List<Guess> _guesses = [];

    public void AddGuess(Guess guess)
    {
        _guesses.Add(guess);
    }

    public int Score { get => TotalScore(); set; }

    public int TotalScore()
    {
        var score = 0.0;
        foreach (var guess in _guesses)
        {
            score += guess.RoundScore();
        }
        return (int)Math.Round(score);
    }
}

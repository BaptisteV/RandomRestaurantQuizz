using RandomRestaurantQuizz.Models;

namespace RandomRestaurantQuizz.Quizzz;

public class Guess
{
    public required PlaceResult Place { get; set; }
    public required double GuessedScore { get; set; }
}

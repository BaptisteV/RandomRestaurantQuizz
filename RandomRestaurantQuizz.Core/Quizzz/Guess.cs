using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class Guess
{
    public required PlaceResult Place { get; set; }
    public required double GuessedScore { get; set; }
}

namespace RandomRestaurantQuizz.Models;

public class QuizzModel
{
    public List<PlaceResult> PlacesToBeAnswered { get; set; } = [];
    public int ActivePlaceIndex { get; set; } = 0;
    public double? GuessInput { get; set; } = null;
}

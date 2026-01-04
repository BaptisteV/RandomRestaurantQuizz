namespace RandomRestaurantQuizz.Core.Models;

public class QuizzModel
{
    public PlaceResult? CurrentPlace { get; set; }
    public List<PlaceResult> PlacesToBeAnswered { get; set; } = [];
    public int ActivePlaceIndex { get; set; } = 0;
    public double? GuessInput { get; set; } = null;

    public override string ToString()
    {
        return $"CurrentPlace={CurrentPlace?.DisplayName?.Text} ActivePlaceIndex={ActivePlaceIndex}, GuessInput={GuessInput}";
    }
}

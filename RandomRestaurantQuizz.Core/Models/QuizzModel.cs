namespace RandomRestaurantQuizz.Core.Models;

public class QuizzModel
{
    public List<PlaceResult> PlacesToBeAnswered { get; set; } = [];
    public int ActivePlaceIndex { get; set; } = 0;
    public double? GuessInput { get; set; } = null;

    public override string ToString()
    {
        return $"QuizzModel: {PlacesToBeAnswered.Count} places, ActivePlaceIndex={ActivePlaceIndex}, GuessInput={GuessInput}";
    }
}

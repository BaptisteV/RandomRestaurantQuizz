using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.Core.Models;

public class QuizzModel
{
    public PlaceResult? CurrentPlace { get; set; }

    public int CurrentPhotoIndex { get; set; } = 0;

    public Player Player { get; set; } = new Player();

    public override string ToString()
    {
        return $"CurrentPlace={CurrentPlace?.DisplayName?.Text}, Score {Player.Score()}";
    }
}

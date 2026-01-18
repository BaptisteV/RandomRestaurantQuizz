namespace RandomRestaurantQuizz.Core.Models;

public class QuizzModel
{
    public byte[] Image { get; set; } = [];

    public int TotalScore { get; set; } = 0;

    public int LastScoreUpdate { get; set; } = -1;

    public double LastRating { get; set; } = 0;

    public string RestaurantName { get; set; } = "";

    public override string ToString()
    {
        return $"CurrentPlace={RestaurantName}, TotalScore {TotalScore}";
    }
}

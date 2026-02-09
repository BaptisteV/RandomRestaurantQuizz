namespace RandomRestaurantQuizz.Core.Places;

public class Round
{
    public string RestaurantName { get; }
    public string LocationName { get; }
    public string Progress { get; }

    public Round(string restaurantName, string locationName, int userRatingCount, int roundCount, int roundNumber)
    {
        RestaurantName = $"{restaurantName} ({userRatingCount} 👤)";
        LocationName = locationName;
        Progress = $"{roundNumber}/{roundCount}";
    }
}

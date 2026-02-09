using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class RestaurantChangedEvent
{
    public string LocationLabel { get; }
    public string RestaurantName { get; }
    public ScoreChangedEvent ScoreChangedEvent { get; }
    public PhotoChangedEvent PhotoChangedEvent { get; }
    public List<Review> Reviews { get; }

    public RestaurantChangedEvent(string restaurantName, string location, int userRatingCount, List<Review> reviews, ScoreChangedEvent scoreChangedEvent, PhotoChangedEvent photoChangedEvent)
    {
        RestaurantName = $"{restaurantName} ({userRatingCount} 👤)";
        LocationLabel = location;
        Reviews = reviews;
        ScoreChangedEvent = scoreChangedEvent;
        PhotoChangedEvent = photoChangedEvent;
    }
}

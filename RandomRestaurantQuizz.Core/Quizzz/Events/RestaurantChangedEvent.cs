using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class RestaurantChangedEvent
{
    public Round Round { get; }
    public ScoreChangedEvent ScoreChangedEvent { get; }
    public PhotoChangedEvent PhotoChangedEvent { get; }
    public List<Review> Reviews { get; }

    public RestaurantChangedEvent(
        Round round,
        List<Review> reviews,
        ScoreChangedEvent scoreChangedEvent,
        PhotoChangedEvent photoChangedEvent)
    {
        Round = round;
        ScoreChangedEvent = scoreChangedEvent;
        PhotoChangedEvent = photoChangedEvent;
        Reviews = reviews;
    }
}

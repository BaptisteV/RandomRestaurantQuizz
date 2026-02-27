using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class RestaurantChangedEvent
{
    public Round Round { get; }
    public PhotoChangedEvent PhotoChangedEvent { get; }
    public List<Review> Reviews { get; }

    public RestaurantChangedEvent(
        Round round,
        List<Review> reviews,
        PhotoChangedEvent photoChangedEvent)
    {
        Round = round;
        PhotoChangedEvent = photoChangedEvent;
        Reviews = reviews;
    }
}

using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Quizzz;

public interface IQuizzGame
{
    Task InitRound((string Name, GeoLoc Geoloc) location, CancellationToken cancellationToken);
    Task Answer(double guessedRating);
    Task NextPhoto();
    Task PreviousPhoto();
    void SetSearchLocation(GeoLoc geoloc, int radius);

    Func<ScoreChangedEvent, Task> ScoreChanged { get; set; }
    Func<PhotoChangedEvent, Task> PhotoChanged { get; set; }
    Func<RoundFinishedEvent, Task> RoundFinished { get; set; }
}
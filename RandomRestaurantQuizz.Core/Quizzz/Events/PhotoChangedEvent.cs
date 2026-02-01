namespace RandomRestaurantQuizz.Core.Quizzz.Events;

public class PhotoChangedEvent
{
    public PhotoChangedEvent(byte[] image)
    {
        Source = ImageSource.FromStream(() => new MemoryStream(image));
    }

    public ImageSource Source { get; }
}

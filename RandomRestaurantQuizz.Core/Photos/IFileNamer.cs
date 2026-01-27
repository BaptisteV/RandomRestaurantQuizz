using RandomRestaurantQuizz.Core.Models;

namespace RandomRestaurantQuizz.Core.Photos;

public interface IFileNamer
{
    string GetFilename(PlaceResult place, int index);
    string Root();
}

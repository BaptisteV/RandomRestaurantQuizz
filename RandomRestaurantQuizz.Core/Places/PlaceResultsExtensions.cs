using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public static class PlaceResultsExtensions
{
    extension(IEnumerable<PlaceResult> source)
    {
        public List<PlaceResult> WithRatingAndPhotos()
        {
            return [..source.Where(r =>
            r.UserRatingCount > 0 &&
            r.Photos.Any(p => !string.IsNullOrWhiteSpace(p.Name)))];
        }
    }
}

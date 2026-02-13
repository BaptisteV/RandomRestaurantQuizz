using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public static class PlaceResultsExtensions
{
    extension(PlacesApiResponse response)
    {
        public PlacesApiResponse WithRatingAndPhotos()
        {
            return new PlacesApiResponse()
            {
                Places = [.. response.Places.Where(r =>
                    r.UserRatingCount > 0
                    && r.Photos.Any(p => !string.IsNullOrWhiteSpace(p.Name)))]
            };
        }
    }
}

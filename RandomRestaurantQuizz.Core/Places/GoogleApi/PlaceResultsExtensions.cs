namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

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

    extension(List<PlaceResult> placeResults)
    {
        public List<PlaceResultWithDistance> OrderByDistance(Geoloc geoloc)
        {
            return [.. placeResults
                .Select(place => new PlaceResultWithDistance
                {
                    Place = place,
                    Distance = Geoloc.GetHaversineDistance(geoloc, place.Location)
                })
                .OrderBy(x => x.Distance)];
        }
    }
}

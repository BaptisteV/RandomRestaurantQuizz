namespace RandomRestaurantQuizz.Core.Places.GoogleApi;

public static class PlaceResultsExtensions
{
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

public static class PlacesApiResponseExtensions
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

        public PlacesApiResponse GetNearestPlaces(Geoloc origin, int limit = 10)
        {
            return new PlacesApiResponse()
            {
                Places = [.. response.Places.OrderByDistance(origin)
                .Take(limit)
                .Select(p =>
                new PlaceResult(){
                    DisplayName = p.Place.DisplayName,
                    FormattedAddress = p.Place.FormattedAddress,
                    Location = p.Place.Location,
                    Photos = p.Place.Photos,
                    Rating = p.Place.Rating,
                    UserRatingCount = p.Place.UserRatingCount
                })]
            };
        }
    }
}
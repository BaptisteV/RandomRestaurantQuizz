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
        public List<PlaceResultWithDistance> OrderByDistance(SearchLocation searchLocation)
        {
            return [.. placeResults
                .Select(place => new PlaceResultWithDistance
                {
                    Place = place,
                    Distance = SearchLocation.GetHaversineDistance(searchLocation, new SearchLocation(){ Latitude = place.Location.Latitude, Longitude = place.Location.Longitude, Name = "" })
                })
                .Where(x => x.Distance <= SearchLocation.CityMatchRadius)
                .OrderBy(x => x.Distance)];
        }
    }
}

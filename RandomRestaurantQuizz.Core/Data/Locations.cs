using RandomRestaurantQuizz.Core.Places.GoogleApi;
using System.Collections.Immutable;

namespace RandomRestaurantQuizz.Core.Data;

public static class Locations
{
    public static readonly IImmutableList<SearchLocation> Cities = new List<SearchLocation>()
    {
        { new SearchLocation { Name = "Dijon", Geoloc = new Geoloc() { Latitude = 47.3220, Longitude = 5.0415 }}},
        { new SearchLocation { Name = "Lyon", Geoloc = new Geoloc() { Latitude = 45.7640, Longitude = 4.8357 }}},
        { new SearchLocation { Name = "Marseille", Geoloc = new Geoloc() { Latitude = 43.2965, Longitude = 5.3698 }}},
        { new SearchLocation { Name = "Paris", Geoloc = new Geoloc() { Latitude = 48.8566, Longitude = 2.3522 }}},
        { new SearchLocation { Name = "Bordeaux", Geoloc = new Geoloc() { Latitude = 44.8378, Longitude = -0.5792 }}},
    }.ToImmutableList();

    extension(IImmutableList<SearchLocation> cities)
    {
        public IEnumerable<SearchLocationWithDistance> OrderByDistance(SearchLocation searchLocation)
        {
            return cities
                .Select(city => new SearchLocationWithDistance
                {
                    Location = city,
                    Distance = Geoloc.GetHaversineDistance(searchLocation.Geoloc, city.Geoloc)
                })
                .OrderBy(x => x.Distance);
        }
    }

    extension(IImmutableList<SearchLocation> cities)
    {
        public SearchLocation Find(string cityName)
        {
            return cities.Single(c => string.Equals(c.Name, cityName, StringComparison.OrdinalIgnoreCase));
        }
    }
}

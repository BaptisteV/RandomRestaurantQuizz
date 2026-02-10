using System.Collections.Immutable;

namespace RandomRestaurantQuizz.Core.Data;

public static class Locations
{
    public static readonly IImmutableList<SearchLocation> Cities = new List<SearchLocation>()
    {
        { new SearchLocation { Name = "Dijon", Latitude = 47.3220, Longitude = 5.0415 }},
        { new SearchLocation { Name = "Lyon", Latitude = 45.7640, Longitude = 4.8357 }},
        { new SearchLocation { Name = "Marseille", Latitude = 43.2965, Longitude = 5.3698 }},
        { new SearchLocation { Name = "Paris", Latitude = 48.8566, Longitude = 2.3522 }},
        { new SearchLocation { Name = "Bordeaux", Latitude = 44.8378, Longitude = -0.5792 }},
    }.ToImmutableList();
}

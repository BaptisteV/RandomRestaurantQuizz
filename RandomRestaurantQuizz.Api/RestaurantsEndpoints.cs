using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace RandomRestaurantQuizz.Api;

public static class RestaurantsEndpoints
{
    public static async Task<Results<Ok<PlacesApiResponse>, NotFound>> GetRestaurantsByCity(
            [FromServices] ICachedPlacesClient googlePlacesClient,
            [FromRoute(Name = "city")] string city,
            CancellationToken cancellationToken)
    {
        var foundCities = Locations.Cities.Where(l => string.Equals(l.Name, city, StringComparison.OrdinalIgnoreCase)).ToList();
        if (foundCities.Count == 0)
        {
            return TypedResults.NotFound();
        }

        var location = foundCities.Single();

        return await GetRestaurantsByCoordinates(googlePlacesClient, location.Latitude, location.Longitude, location.Name, cancellationToken);
    }

    public static async Task<Ok<PlacesApiResponse>> GetRestaurantsByCoordinates(
            [FromServices] IGooglePlacesClient googlePlacesClient,
            [FromQuery(Name = "lat")] double lat,
            [FromQuery(Name = "lng")] double lng,
            [FromQuery(Name = "name")] string? name,
            CancellationToken cancellationToken)
    {
        var location = new SearchLocation() { Latitude = lat, Longitude = lng, Name = name ?? "" };
        var places = await googlePlacesClient.GetRestaurants(location, cancellationToken);
        return TypedResults.Ok(new PlacesApiResponse() { Places = places });
    }
}
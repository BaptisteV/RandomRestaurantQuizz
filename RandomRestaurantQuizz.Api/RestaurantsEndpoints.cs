using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace RandomRestaurantQuizz.Api;

public static class RestaurantsEndpoints
{
    public static async Task<Ok<PlacesApiResponse>> GetRestaurantsByCity(
            [FromServices] ICachedPlacesClient cachedPlacesClient,
            [FromRoute(Name = "city")] string city,
            [FromQuery(Name = "lang")] string lang,
            CancellationToken cancellationToken)
    {
        var location = Locations.Cities.Find(city);
        return await GetRestaurantsByCoordinates(cachedPlacesClient, location.Geoloc.Latitude, location.Geoloc.Longitude, location.Name, lang, cancellationToken);
    }

    public static async Task<Ok<PlacesApiResponse>> GetRestaurantsByCoordinates(
            [FromServices] ICachedPlacesClient cachedPlacesClient,
            [FromQuery(Name = "lat")] double lat,
            [FromQuery(Name = "lng")] double lng,
            [FromQuery(Name = "name")] string? name,
            [FromQuery(Name = "lang")] string lang,
            CancellationToken cancellationToken)
    {
        var location = new SearchParams()
        {
            Language = lang,
            Location = new SearchLocation()
            {
                Geoloc = new Geoloc() { Latitude = lat, Longitude = lng },
                Name = name ?? "",
            }
        };
        var places = await cachedPlacesClient.GetRestaurantsWithCache(location, cancellationToken);
        return TypedResults.Ok(places);
    }
}
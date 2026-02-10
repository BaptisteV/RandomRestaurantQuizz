using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddCoreServices();
builder.Services.AddSingleton<IPhotoDownloader, NoOpPhotoDownloader>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(o =>
    {
        o.Title = "RestauQuizz API";
    });
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.MapGet("/restaurants", RestaurantsEndpoints.GetRestaurantsByCoordinates)
    .WithName(nameof(RestaurantsEndpoints.GetRestaurantsByCoordinates))
    .WithDisplayName("GET restaurants by coordinates");

app.MapGet("/restaurants/{city}", RestaurantsEndpoints.GetRestaurantsByCity)
    .WithName(nameof(RestaurantsEndpoints.GetRestaurantsByCity))
    .WithDisplayName("GET restaurants by city");

await app.RunAsync();


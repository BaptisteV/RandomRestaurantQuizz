using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Configuration.AddSecretsFromRessources();
builder.Services.AddCoreServices();
builder.Services.AddTransient((_) => new SqliteDbPath() { DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "scores.db") });
builder.Services.AddSingleton<IPhotoDownloader, NoOpPhotoDownloader>();
builder.Services.AddTransient<ICachedPlacesClient, DuckCachedPlacesClient>();
builder.Services.AddTransient<PlacesCacheRepository>();

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


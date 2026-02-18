using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Host
    .UseDefaultServiceProvider(o =>
    {
        o.ValidateScopes = true;
        o.ValidateOnBuild = true;
    })
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders().AddDebug().SetMinimumLevel(LogLevel.Information);
#if DEBUG
        logging.SetMinimumLevel(LogLevel.Debug);
        logging.AddSimpleConsole(options =>
        {
            options.IncludeScopes = false;
            options.SingleLine = true;
            options.TimestampFormat = "[HH:mm:ss:fff] ";
        });
#endif
    });

builder.Services.AddOpenApi();
builder.Configuration.AddSecretsFromRessources();
builder.Services.AddCoreServices();
builder.Services.AddTransient((_) => new AppDataDb() { DbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "scores.db") });
builder.Services.AddTransient<IPhotoDownloader, NoOpPhotoDownloader>();
builder.Services.AddHttpClient<IGooglePlacesClient, GooglePlacesClient>();
builder.Services.AddScoped<ICachedPlacesClient, DuckDbCachedPlacesClient>();

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


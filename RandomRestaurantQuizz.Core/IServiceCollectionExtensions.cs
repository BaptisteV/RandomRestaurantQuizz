using Microsoft.Extensions.Configuration;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.SoundEffects;
using System.Reflection;

namespace RandomRestaurantQuizz.Core;

public static class IServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public void AddCoreServices()
        {
            services.AddHttpClient<IGooglePlacesClient, GooglePlacesClient>(a =>
            {
                a.BaseAddress = new Uri("https://places.googleapis.com/v1/places:searchNearby");
            });

            services.AddHttpClient<IPhotoDownloader, PhotoDownloader>();
            services.AddTransient<IFileNamer, FileNamer>();
            services.AddTransient<PhotoFileManager>();

            services.AddSingleton(Plugin.Maui.Audio.AudioManager.Current);
            services.AddSingleton<ISoundEffect, ResourceSoundEffect>();
            services.AddSingleton<IScoreRepository, SqliteScoreRepository>();
            services.AddSingleton<IQuizzGame, QuizzGame>();

            services.AddSingleton(sp =>
            {
                var apiKey = sp.GetRequiredService<IConfiguration>().GetRequiredSection("GOOGLE_PLACES_API_KEY").Value;
                if (string.IsNullOrWhiteSpace(apiKey))
                {
                    throw new InvalidOperationException("GOOGLE_PLACES_API_KEY not found");
                }

                return new SecretsJson() { GooglePlacesApiKey = apiKey };
            });
        }
    }

    private static Stream ReadSecretsJson()
    {
        var secretsPath = $"{typeof(ICoreProject).Namespace}.secrets.json";
        // Load embedded JSON secrets file
        var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream(secretsPath) ?? throw new InvalidOperationException(secretsPath);

        return stream;
    }

    extension(IConfigurationBuilder configBuilder)
    {
        public void AddSecretsFromRessources()
        {
            using var stream = ReadSecretsJson();
            configBuilder.AddJsonStream(stream);
        }
    }

    extension(IConfigurationManager configManager)
    {
        public void AddSecretsFromRessources()
        {
            ((IConfigurationBuilder)configManager).AddSecretsFromRessources();
        }
    }

}
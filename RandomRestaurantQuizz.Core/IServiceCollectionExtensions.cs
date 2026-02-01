using Microsoft.Extensions.Configuration;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.Quizzz.Scores;
using RandomRestaurantQuizz.Core.SoundEffects;
using System.Reflection;

namespace RandomRestaurantQuizz.Core;

public static class IServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public void AddCoreServices()
        {
            services.AddHttpClient<IGooglePlacesClient, GooglePlacesStaticClient>(a =>
            {
                a.BaseAddress = new Uri("https://places.googleapis.com/v1/places:searchNearby");
            });

            services.AddHttpClient<IPhotoDownloader, PhotoDownloader>();
            services.AddTransient<IFileNamer, FileNamer>();
            services.AddTransient<PhotoFileManager>();

            services.AddSingleton(Plugin.Maui.Audio.AudioManager.Current);
            services.AddSingleton<ISoundEffect, SoundEffectGenerator>();
            services.AddSingleton<IScoreSaver, SqlLiteScoreSaver>();
            services.AddSingleton<IQuizzGame, QuizzGame>();

            services.AddSecretsFromRessources();
        }

        private void AddSecretsFromRessources()
        {
            var secretsPath = $"{typeof(ICoreProject).Namespace}.secrets.json";

            // Load embedded JSON secrets file
            using var stream = Assembly
                .GetExecutingAssembly()
                .GetManifestResourceStream(secretsPath) ?? throw new InvalidOperationException(secretsPath);

            var secrets = new ConfigurationBuilder()
                .AddJsonStream(stream)
                .Build();

            var apiKey = secrets.GetRequiredSection("GOOGLE_PLACES_API_KEY").Value;

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new InvalidOperationException("GOOGLE_PLACES_API_KEY not found");
            }

            services.Configure<SecretsJson>(c =>
            {
                c.GooglePlacesApiKey = apiKey;
            });
        }
    }
}
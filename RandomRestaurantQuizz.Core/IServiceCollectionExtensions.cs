using Microsoft.Extensions.Configuration;
using RandomRestaurantQuizz.Core.Config;
using System.Reflection;

namespace RandomRestaurantQuizz.Core;

public static class IServiceCollectionExtensions
{
    private static string ReadConfig(IServiceProvider sp, string section)
    {
        var quizzApi = sp.GetRequiredService<IConfiguration>().GetRequiredSection(section).Value;
        if (string.IsNullOrWhiteSpace(quizzApi))
        {
            throw new InvalidOperationException($"{section} not found");
        }

        return quizzApi;
    }

    extension(IServiceCollection services)
    {
        public void AddCoreServices()
        {
            services.AddSingleton(sp =>
            {
                var apiKey = ReadConfig(sp, "GOOGLE_PLACES_API_KEY");

                return new SecretsJson() { GooglePlacesApiKey = apiKey };
            });

            services.AddSingleton(sp =>
            {
                var quizzApi = ReadConfig(sp, "QuizzApi");
                var googlePlacesApi = ReadConfig(sp, "GooglePlacesApi");
                var googlePhotosApi = ReadConfig(sp, "GooglePhotosApi");

                return new ApiUrls()
                {
                    QuizzApi = quizzApi,
                    GooglePlacesApi = googlePlacesApi,
                    GooglePhotosApi = googlePhotosApi,
                };
            });
        }
    }

    private static Stream ReadJsonRessource(string name)
    {
        var jsonPath = $"{typeof(ICoreProject).Namespace}.{name}.json";
        // Load embedded JSON secrets file
        var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream(jsonPath) ?? throw new InvalidOperationException(jsonPath);

        return stream;
    }

    extension(IConfigurationBuilder configBuilder)
    {
        public void AddSecrets()
        {
            using var stream = ReadJsonRessource("secrets");
            configBuilder.AddJsonStream(stream);
        }

        public void AddAppsettings()
        {
            using var stream = ReadJsonRessource("appsettings");
            configBuilder.AddJsonStream(stream);
        }
    }

    extension(IConfigurationManager configManager)
    {
        public void AddSecrets()
        {
            ((IConfigurationBuilder)configManager).AddSecrets();
        }

        public void AddAppsettings()
        {
            ((IConfigurationBuilder)configManager).AddAppsettings();
        }
    }
}
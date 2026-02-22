using RandomRestaurantQuizz.Core.Places.GoogleApi;
using System.Text;

namespace RandomRestaurantQuizz.Core.Photos;

public class FileNamer : IFileNamer
{
    private const string FOLDER = "Local/RandomRestaurantQuizz";

    public FileNamer(ILogger<FileNamer> logger)
    {
        var root = Path.GetFullPath(Root());
        logger.LogInformation("Root folder for caching: {Root}", root);
    }

    public string Root()
    {
        return Path.Combine(FileSystem.CacheDirectory, FOLDER);
    }

    private static string SanitizeFileName(string fileName, char replacement = '_')
    {
        var defaultFileName = $"{Guid.NewGuid()}.jpg";
        if (string.IsNullOrWhiteSpace(fileName))
            return defaultFileName;

        var invalidChars = Path.GetInvalidFileNameChars();
        var builder = new StringBuilder(fileName.Length);

        foreach (var c in fileName)
        {
            builder.Append(invalidChars.Contains(c) ? replacement : c);
        }

        var sanitized = builder.ToString().Trim();
        return string.IsNullOrEmpty(sanitized) ? defaultFileName : sanitized;
    }

    public string GetFilename(PlaceResult place, int index)
    {
        var file = SanitizeFileName($"{place.DisplayName.Text}-{index.ToString().PadLeft(2, '0')}.jpg");
        var root = Root();
        return Path.Combine(root, file);
    }
}
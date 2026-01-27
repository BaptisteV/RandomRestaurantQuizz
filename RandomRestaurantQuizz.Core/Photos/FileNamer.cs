using RandomRestaurantQuizz.Core.Models;
using System.Text;

namespace RandomRestaurantQuizz.Core.Photos;

public class FileNamer : IFileNamer
{
    private const string FOLDER = "RandomRestaurantQuizz";

    public string Root()
    {
        return Path.Combine(FileSystem.CacheDirectory, FOLDER);
    }

    public static string SanitizeFileName(string fileName, char replacement = '_')
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
        var root = Path.Combine(Path.GetTempPath(), FOLDER);
        var file = SanitizeFileName($"{place.DisplayName.Text}-{index.ToString().PadLeft(2, '0')}.jpg");
        return Path.Combine(root, file);
    }
}
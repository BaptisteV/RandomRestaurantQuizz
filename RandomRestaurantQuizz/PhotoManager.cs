using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Models;
using System.Diagnostics;
using System.Text;

namespace RandomRestaurantQuizz;

public class PhotoManager(HttpClient _httpClient, string _apiKey, ILogger<PhotoManager> _logger)
{
    private const string FOLDER = "RandomRestaurantQuizz";

    public async Task OpenFirstImage(PlaceResult result)
    {
        var tempPath = await SaveTempJpg(result, 0);
        Process.Start(new ProcessStartInfo(tempPath) { UseShellExecute = true });
    }

    private string GetPhotoUrl(string photoName, int maxWidth = 800)
    {
        var segments = photoName.Split('/');
        var placeId = segments[1];
        var photoReference = segments[3];
        var url = $"https://places.googleapis.com/v1/places/{placeId}/photos/{photoReference}/media?key={_apiKey}&maxWidthPx={maxWidth}";
        return url;
    }

    public async Task<byte[]> GetImage(Photo photo, CancellationToken cancellationToken)
    {
        var url = GetPhotoUrl(photo.Name!);
        using var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsByteArrayAsync(cancellationToken);
    }

    public async Task<IList<PlaceResult>> GetFirstImages(List<PlaceResult> placeResults, CancellationToken cancellationToken)
    {
        var downloadTasks = placeResults
            .Select(async (place, i) =>
            {
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var photo = place.Photos?.FirstOrDefault(p => p?.Name is not null);
                    if (photo is null)
                        throw new InvalidOperationException($"No photo to download for {place.DisplayName?.Text}");

                    if (ShouldDownload(place, 0))
                    {
                        place.FirstImage = await GetImage(photo, cancellationToken);
                    }
                    else
                    {
                        place.FirstImage = await File.ReadAllBytesAsync(GetFilename(place, 0), cancellationToken);
                    }

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to get image for place: {PlaceName}", place.DisplayName?.Text);
                }
            })
            .ToList();

        await Task.WhenAll(downloadTasks);

        return placeResults;
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

    private static string GetFilename(PlaceResult place, int index)
    {
        var root = Path.Combine(Path.GetTempPath(), FOLDER);
        var file = SanitizeFileName($"{place.DisplayName?.Text}-{index.ToString().PadLeft(2, '0')}.jpg");
        return Path.Combine(root, file);
    }

    private bool ShouldDownload(PlaceResult place, int photoIndex)
    {
        if (File.Exists(GetFilename(place, photoIndex)))
        {
            _logger.LogInformation("Photo {PhotoIndex} already exists for {PlaceName}, skipping download.", photoIndex, place.DisplayName?.Text);
            return false;
        }
        return true;
    }

    private static async Task<string> SaveTempJpg(PlaceResult place, int photoIndex)
    {
        var tempFileName = GetFilename(place, photoIndex);
        if (!Directory.Exists(Path.GetDirectoryName(tempFileName)!))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(tempFileName)!);
        }
        await File.WriteAllBytesAsync(tempFileName, place.FirstImage!);

        return tempFileName;
    }
}

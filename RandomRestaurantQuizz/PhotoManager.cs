using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Models;
using System.Diagnostics;

namespace RandomRestaurantQuizz;

public class PhotoManager(
    HttpClient _httpClient,
    string _apiKey,
    ILogger<PhotoManager> _logger)
{
    private const string FOLDER = "RandomRestaurantQuizz";
    private static async Task<string> SaveToTempFile(byte[] imageData, string extension = "jpg")
    {
        // Create a unique temp file
        var tempFileName = Path.Combine(Path.GetTempPath(), FOLDER, $"{Guid.NewGuid()}.{extension}");
        if (!Directory.Exists(Path.GetDirectoryName(tempFileName)!))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(tempFileName)!);
        }
        await File.WriteAllBytesAsync(tempFileName, imageData);

        return tempFileName;
    }

    public async Task DisplayFirstImage(PlaceResult result)
    {
        if (result.FirstImage?.Length == 0 || result.FirstImage == null)
        {
            _logger.LogInformation("No image available for {PlaceName}", result.DisplayName?.Text);
            return;
        }

        var tempPath = await SaveToTempFile(result.FirstImage, "jpg");
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

    public async Task<byte[]> GetImage(PlaceResult place, CancellationToken cancellationToken)
    {
        var firstPhoto = place.Photos?.FirstOrDefault();
        if (firstPhoto?.Name is null)
        {
            _logger.LogError("Can't get image for place without photo: {PlaceName}", place.DisplayName);
            return [];
        }
        var url = GetPhotoUrl(firstPhoto.Name);
        var photoData = await DownloadPhotoIfPossible(url, cancellationToken);
        return photoData;
    }

    private async Task<byte[]> DownloadPhotoIfPossible(string url, CancellationToken cancellationToken)
    {
        try
        {
            using var response = await _httpClient.GetAsync(url, cancellationToken);
            response.EnsureSuccessStatusCode();

            // Read the response as byte array
            var data = await response.Content.ReadAsByteArrayAsync(cancellationToken);
            return data;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to download photo from {url}", url);
            return [];
        }
    }


    public async Task<IList<PlaceResult>> GetAllImages(List<PlaceResult> placeResults, CancellationToken cancellationToken)
    {
        foreach (var place in placeResults)
        {
            var photo = place.Photos?.FirstOrDefault();
            if (photo?.Name is null)
            {
                _logger.LogError("Can't get image for place without photo: {PlaceName}", place.DisplayName.Text);
                continue;
            }
            place.FirstImage = await GetImage(place, cancellationToken);
        }
        return placeResults;
    }
}

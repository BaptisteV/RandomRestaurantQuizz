using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Models;

namespace RandomRestaurantQuizz.Photos;

public class PhotoDownloader
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly IFileNamer _fileNamer;
    private readonly ILogger<PhotoDownloader> _logger;
    public PhotoDownloader(HttpClient httpClient, string apiKey, IFileNamer fileNamer, ILogger<PhotoDownloader> logger)
    {
        _httpClient = httpClient;
        _apiKey = apiKey;
        _logger = logger;
        _fileNamer = fileNamer;
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

    private bool ShouldDownload(PlaceResult place, int photoIndex)
    {
        var filename = _fileNamer.GetFilename(place, photoIndex);
        if (!File.Exists(filename))
            return true;

        if (new FileInfo(filename).Length == 0)
            return true;

        _logger.LogInformation("Photo {PhotoIndex} already exists for {PlaceName}, skipping download.", photoIndex, place.DisplayName?.Text);
        return false;
    }

    public async Task<IList<PlaceResult>> GetPhotos(List<PlaceResult> placeResults, CancellationToken cancellationToken)
    {
        var downloadTasks = placeResults
            .Select(async (place, i) =>
            {
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    for (var p = 0; p < place.Photos!.Count; p++)
                    {
                        if (ShouldDownload(place, p))
                        {
                            var image = await GetImage(place.Photos[p], cancellationToken);
                            place.Photos[p].DownloadedImage = image;
                        }
                        else
                        {
                            var image = await File.ReadAllBytesAsync(_fileNamer.GetFilename(place, p), cancellationToken);
                            place.Photos[p].DownloadedImage = image;
                        }
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

}

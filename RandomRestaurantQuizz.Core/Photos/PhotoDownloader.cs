using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Places;
using System.Diagnostics;

namespace RandomRestaurantQuizz.Core.Photos;

public class PhotoDownloader : IPhotoDownloader
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly IFileNamer _fileNamer;
    private readonly ILogger<PhotoDownloader> _logger;
    public PhotoDownloader(HttpClient httpClient, IOptionsMonitor<SecretsJson> config, IFileNamer fileNamer, ILogger<PhotoDownloader> logger)
    {
        _httpClient = httpClient;
        _apiKey = config.CurrentValue.GooglePlacesApiKey;
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

    private async Task<byte[]> GetImage(Photo photo, CancellationToken cancellationToken)
    {
        var url = GetPhotoUrl(photo.Name!);
        _logger.LogDebug("Downloading: {DownloadUrl}", url);
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

        _logger.LogDebug("Photo {PhotoIndex} already exists for {PlaceName}, skipping download.", photoIndex, place.DisplayName?.Text);
        return false;
    }

    public async Task<List<PlaceResult>> GetPhotos(List<PlaceResult> placeResults, CancellationToken cancellationToken)
    {
        var sw = Stopwatch.StartNew();
        var downloadTasks = placeResults
            .Select(async (place, i) =>
            {
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    if (place.Photos is null)
                    {
                        _logger.LogWarning("No photo for {PlaceName}", place.DisplayName?.Text);
                        return;
                    }

                    for (var p = 0; p < place.Photos.Count; p++)
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
                    throw;
                }
            })
            .ToList();

        await Task.WhenAll(downloadTasks);

        var elapsed = sw.Elapsed;
        _logger.LogInformation("Downloaded all photos in {DlElapsed}", elapsed);

        return placeResults;
    }
}
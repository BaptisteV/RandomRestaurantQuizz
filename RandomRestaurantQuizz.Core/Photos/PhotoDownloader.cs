using RandomRestaurantQuizz.Core.Places.Api;
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

    private bool PhotoInCache(PlaceResult place, int photoIndex)
    {
        var filename = _fileNamer.GetFilename(place, photoIndex);

        var rootDir = Path.GetDirectoryName(filename)!;
        if (!Directory.Exists(rootDir))
        {
            Directory.CreateDirectory(rootDir);
        }

        if (!File.Exists(filename))
            return true;

        if (new FileInfo(filename).Length == 0)
            return true;

        _logger.LogDebug("Photo {PhotoIndex} already exists for {PlaceName}, skipping download.", photoIndex, place.DisplayName.Text);
        return false;
    }

    public async Task<List<PlaceResult>> GetPhotos(List<PlaceResult> placeResults, CancellationToken cancellationToken)
    {
        var sw = Stopwatch.StartNew();
        var downloadTasks = placeResults.Select((place, i) => DownloadRestaurantPhotosTask(place, cancellationToken));

        await Task.WhenAll(downloadTasks);

        var elapsed = sw.Elapsed;
        _logger.LogInformation("Got all photos in {DlElapsed}", elapsed);

        return placeResults;
    }

    private async Task<bool> DownloadRestaurantPhotosTask(PlaceResult place, CancellationToken cancellationToken)
    {
        try
        {
            if (place.Photos.Count == 0)
            {
                _logger.LogWarning("No photo for {PlaceName}", place.DisplayName.Text);
                return false;
            }

            for (var p = 0; p < place.Photos.Count; p++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (PhotoInCache(place, p))
                {
                    var image = await GetImage(place.Photos[p], cancellationToken);
                    await File.WriteAllBytesAsync(_fileNamer.GetFilename(place, p), image, cancellationToken);
                    place.Photos[p].DownloadedImage = image;
                }
                else
                {
                    var image = await File.ReadAllBytesAsync(_fileNamer.GetFilename(place, p), cancellationToken);
                    place.Photos[p].DownloadedImage = image;
                }
            }
        }
        catch (HttpRequestException reqException)
        {
            _logger.LogError(reqException, "Failed to get image for place: {PlaceName}", place.DisplayName.Text);
            throw;
        }
        catch (OperationCanceledException cancelledException)
        {
            _logger.LogError(cancelledException, "Getting image canceled for: {PlaceName}", place.DisplayName.Text);
            throw;
        }

        return true;
    }
}
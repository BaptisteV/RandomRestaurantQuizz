using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Models;
using System.Diagnostics;

namespace RandomRestaurantQuizz.Core.Photos;

public class PhotoFileManager
{
    private readonly IFileNamer _fileNamer;
    private readonly ILogger<PhotoFileManager> _logger;

    public PhotoFileManager(IFileNamer fileNamer, ILogger<PhotoFileManager> logger)
    {
        _fileNamer = fileNamer;
        _logger = logger;
    }

    public void OpenTempFolder()
    {
        Process.Start(new ProcessStartInfo(_fileNamer.Root()) { UseShellExecute = true });
    }

    public async Task SaveTempJpgs(PlaceResult place)
    {
        var root = _fileNamer.Root();
        if (!Directory.Exists(Path.GetDirectoryName(root)!))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(root)!);
        }

        var writes = place.Photos
            .Select(async (ph, i) =>
            {
                try
                {
                    if (ph.DownloadedImage is not null)
                    {
                        var tempFileName = _fileNamer.GetFilename(place, i);
                        await File.WriteAllBytesAsync(tempFileName, ph.DownloadedImage);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to save image for place: {PlaceName}", place.DisplayName?.Text);
                }
            })
            .ToList();

        await Task.WhenAll(writes);
    }
}

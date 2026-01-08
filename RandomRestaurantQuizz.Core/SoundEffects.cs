using Plugin.Maui.Audio;

namespace RandomRestaurantQuizz.Core;

public class SoundEffects
{
    private readonly IAudioManager _audioManager;
    private IAudioPlayer _winSound;
    private IAudioPlayer _looseSound;

    public SoundEffects(IAudioManager audioManager)
    {
        _audioManager = audioManager;
    }

    public async Task Init()
    {
        _winSound = _audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("win.wav"));
        _looseSound = _audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("loose.wav"));
    }

    public void PlayWin()
    {
        _winSound.Play();
    }

    public void PlayLoose()
    {
        _looseSound.Play();
    }
}

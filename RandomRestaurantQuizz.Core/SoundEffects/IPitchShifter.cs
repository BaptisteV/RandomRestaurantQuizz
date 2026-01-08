using Plugin.Maui.Audio;

namespace RandomRestaurantQuizz.Core.SoundEffects;

public interface IPitchShifter
{
    AsyncAudioPlayer ShiftBy(AsyncAudioPlayer sample, double shiftByPercent);
}

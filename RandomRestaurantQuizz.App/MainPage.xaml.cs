using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> _logger;
    private readonly ISoundEffect _soundEffects;
    private readonly IQuizz _quizz;

    public MainPage(IQuizz quizz, ILogger<MainPage> logger, ISoundEffect soundEffects)
    {
        _quizz = quizz;

        _logger = logger;
        _soundEffects = soundEffects;
        InitializeComponent();

        _quizz.ScoreChanged = async (model) =>
        {
            var newScore = model.Player.Score();
            ScoreLabel.Text = $"Score: {newScore:F2}";

            if (model.LastGuess is not null)
            {
                var scoreDiff = model.LastGuess.ScoreDiffPercentage();
                await _soundEffects.PlayAnswer(correctnessPercentage: scoreDiff, CancellationToken.None);
            }
            else
            {
                _logger.LogWarning("No last guess");
            }
        };

        _quizz.PhotoChanged = async (model) =>
        {
            var photos = model.CurrentPlace?.Photos;
            var photo = photos?.ElementAtOrDefault(model.CurrentPhotoIndex);
            if (photo is not null)
            {
                var ms = new MemoryStream(photo.DownloadedImage!);
                RestaurantPhotoImage.Source = ImageSource.FromStream(() => ms);
            }
        };
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        await _soundEffects.Init();
        await _quizz.DownloadRestaurants();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var x = e.GetPosition(PhotoContainer)!.Value.X;
        var width = PhotoContainer.Width;
        var xPercent = 100.0 * x / width;

        // Tap sides to change photo
        if (xPercent <= 25)
        {
            await _quizz.PreviousPhoto();
        }
        else if (xPercent >= 75)
        {
            await _quizz.NextPhoto();
        }
    }

    private void RatingSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        RatingLabel.Text = $"{e.NewValue:F1}";
        Stars.Rating = e.NewValue;
    }

    private void AnswerBtn_Clicked(object sender, EventArgs e)
    {
        _quizz.Answer(RatingSlider.Value);
    }
}

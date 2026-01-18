using RandomRestaurantQuizz.Core;
using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage
{
    private readonly IQuizz _quizz;
    private readonly IQuizzUIHandler _uiHandler;

    public MainPage(IQuizz quizz, IQuizzUIHandler uIHandler)
    {
        _quizz = quizz;
        _uiHandler = uIHandler;
        InitializeComponent();
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        _quizz.Answer(RatingSlider.Value);
        ApplyState();
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        await _uiHandler.Init(ScoreLabel);
        await _quizz.Init().ContinueWith(async (_) =>
        {
            await MainThread.InvokeOnMainThreadAsync(() =>
            {
                ApplyState();
            });
        });
    }

    private void ApplyState()
    {
        var model = _quizz.CurrentState();
        var photos = model.CurrentPlace?.Photos;
        var photo = photos?.ElementAtOrDefault(model.CurrentPhotoIndex);
        if (photo is not null)
        {
            var ms = new MemoryStream(photo.DownloadedImage!);
            RestaurantPhotoImage.Source = ImageSource.FromStream(() => ms);
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var x = e.GetPosition(PhotoContainer)!.Value.X;
        var width = PhotoContainer.Width;
        var xPercent = 100.0 * x / width;

        // Tap sides to change photo
        if (xPercent <= 25)
        {
            _quizz.PreviousPhoto();
            ApplyState();
        }
        else if (xPercent >= 75)
        {
            _quizz.NextPhoto();
            ApplyState();
        }
    }

    private void RatingSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        RatingLabel.Text = $"{e.NewValue:F1}";
        Stars.Rating = e.NewValue;
    }
}

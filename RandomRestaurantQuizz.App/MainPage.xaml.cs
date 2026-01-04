using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly IQuizz _quizz;
        public MainPage(IQuizz quizz)
        {
            _quizz = quizz;
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            _quizz.Answer(4.5);
            ApplyState();
        }

        private async void ContentPage_Loaded(object sender, EventArgs e)
        {
            await _quizz.Init();
            ApplyState();
        }

        private int _photoIndex = 0;
        private void ApplyState()
        {
            var model = _quizz.CurrentState();
            var photos = model.CurrentPlace?.Photos;
            var photo = photos?.ElementAtOrDefault(_photoIndex);
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
            if (xPercent <= 20)
            {
                _photoIndex = Math.Max(0, _photoIndex - 1);
                ApplyState();
            }
            else if (xPercent >= 80)
            {
                var maxIndex = _quizz.CurrentState().CurrentPlace!.Photos!.Count - 1;
                _photoIndex = Math.Min(_photoIndex + 1, maxIndex);
                ApplyState();
            }
        }

        private void RatingSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            RatingLabel.Text = $"{e.NewValue:F1}";
        }
    }
}

namespace RandomRestaurantQuizz.App.Pages.MainPage;

public class MainPageTransitions(
    Image restaurantImage,
    Label restaurantNameLabel,
    CollectionView reviewsContainer,
    Button answerButton) : ITransitions
{
    private readonly Image _restaurantImage = restaurantImage;
    private readonly Label _restaurantNameLabel = restaurantNameLabel;
    private readonly CollectionView _reviewsContainer = reviewsContainer;
    private readonly Button _answerButton = answerButton;

    public void AnimateRestaurantEnd()
    {
        _answerButton.IsEnabled = false;
        _ = Task.Run(async () =>
        {
            var fadeImage = _restaurantImage.FadeToAsync(0, 250);
            var fadeName = _restaurantNameLabel.FadeToAsync(0, 250);
            var fades = _reviewsContainer
                .GetVisualTreeDescendants()
                .Where(e => e.GetType() == typeof(Label))
                .Select(l => ((Label)l).FadeToAsync(0, 250))
                .Concat([fadeImage, fadeName]);
            await Task.WhenAll(fades);
        });
    }

    public void AnimateRestaurantStart()
    {
        _answerButton.IsEnabled = true;
        _ = Task.Run(async () =>
        {
            // Cancel animations
            _restaurantImage.CancelAnimations();
            _restaurantNameLabel.CancelAnimations();
            var labels = _reviewsContainer
                .GetVisualTreeDescendants()
                .OfType<Label>().ToList();
            labels.ForEach(l => l.CancelAnimations());

            // Quickly animate back to 1.0
            var fadeImage = _restaurantImage.FadeToAsync(1.0, 50);
            var fadeName = _restaurantNameLabel.FadeToAsync(1.0, 50);
            var fades = labels
                .Select(l => l.FadeToAsync(1.0, 50))
                .Concat([fadeImage, fadeName]);

            await Task.WhenAll(fades);
        });
    }
}

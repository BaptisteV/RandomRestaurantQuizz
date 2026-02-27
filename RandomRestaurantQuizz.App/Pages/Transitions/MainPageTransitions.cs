namespace RandomRestaurantQuizz.App.Pages.Transitions;

public class MainPageTransitions
{
    private readonly Image restaurantImage;
    private readonly Label restaurantNameLabel;
    private readonly CollectionView reviewsContainer;
    private readonly Button anserButton;

    public MainPageTransitions(
        Image restaurantImage,
        Label restaurantNameLabel,
        CollectionView reviewsContainer,
        Button anserButton)
    {
        this.restaurantImage = restaurantImage;
        this.restaurantNameLabel = restaurantNameLabel;
        this.reviewsContainer = reviewsContainer;
        this.anserButton = anserButton;
    }


    public void AnimateRestaurantEnd()
    {
        anserButton.IsEnabled = false;
        _ = Task.Run(async () =>
        {
            var fadeImage = restaurantImage.FadeToAsync(0, 250);
            var fadeName = restaurantNameLabel.FadeToAsync(0, 250);
            var fades = reviewsContainer
                .GetVisualTreeDescendants()
                .Where(e => e.GetType() == typeof(Label))
                .Select(l => ((Label)l).FadeToAsync(0, 250))
                .Concat([fadeImage, fadeName]);
            await Task.WhenAll(fades);
        });
    }

    public void AnimateRestaurantStart()
    {
        anserButton.IsEnabled = true;
        _ = Task.Run(async () =>
        {
            // Cancel animations
            restaurantImage.CancelAnimations();
            restaurantNameLabel.CancelAnimations();
            var labels = reviewsContainer
                .GetVisualTreeDescendants()
                .OfType<Label>().ToList();
            labels.ForEach(l => l.CancelAnimations());

            // Quickly animate back to 1.0
            var fadeImage = restaurantImage.FadeToAsync(1.0, 50);
            var fadeName = restaurantNameLabel.FadeToAsync(1.0, 50);
            var fades = labels
                .Select(l => l.FadeToAsync(1.0, 50))
                .Concat([fadeImage, fadeName]);

            await Task.WhenAll(fades);
        });
    }
}

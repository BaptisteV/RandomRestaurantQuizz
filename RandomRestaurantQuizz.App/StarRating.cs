namespace RandomRestaurantQuizz.App;

public class StarRating : ContentView
{
    public static readonly BindableProperty RatingProperty =
        BindableProperty.Create(
            nameof(Rating),
            typeof(double),
            typeof(StarRating),
            0.0,
            propertyChanged: OnRatingChanged);

    public static readonly BindableProperty StarSizeProperty =
        BindableProperty.Create(
            nameof(StarSize),
            typeof(double),
            typeof(StarRating),
            30.0,
            propertyChanged: OnStarSizeChanged);

    public static readonly BindableProperty StarColorProperty =
        BindableProperty.Create(
            nameof(StarColor),
            typeof(Color),
            typeof(StarRating),
            Colors.Gold,
            propertyChanged: OnStarColorChanged);

    public static readonly BindableProperty EmptyStarColorProperty =
        BindableProperty.Create(
            nameof(EmptyStarColor),
            typeof(Color),
            typeof(StarRating),
            Colors.LightGray,
            propertyChanged: OnEmptyStarColorChanged);

    public double Rating
    {
        get => (double)GetValue(RatingProperty);
        set => SetValue(RatingProperty, value);
    }

    public double StarSize
    {
        get => (double)GetValue(StarSizeProperty);
        set => SetValue(StarSizeProperty, value);
    }

    public Color StarColor
    {
        get => (Color)GetValue(StarColorProperty);
        set => SetValue(StarColorProperty, value);
    }

    public Color EmptyStarColor
    {
        get => (Color)GetValue(EmptyStarColorProperty);
        set => SetValue(EmptyStarColorProperty, value);
    }

    private readonly HorizontalStackLayout _container;
    private readonly List<Grid> _stars = [];

    public StarRating()
    {
        _container = new HorizontalStackLayout
        {
            Spacing = 4
        };

        for (int i = 0; i < 5; i++)
        {
            var starContainer = new Grid
            {
                IsClippedToBounds = true,
                WidthRequest = StarSize,
                HeightRequest = StarSize
            };

            var backgroundStar = new Label
            {
                Text = "★",
                FontSize = StarSize,
                TextColor = EmptyStarColor,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var foregroundClip = new Grid
            {
                IsClippedToBounds = true,
                WidthRequest = 0,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill
            };

            var foregroundStar = new Label
            {
                Text = "★",
                FontSize = StarSize,
                TextColor = StarColor,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                WidthRequest = StarSize
            };

            foregroundClip.Add(foregroundStar);
            starContainer.Add(backgroundStar);
            starContainer.Add(foregroundClip);

            _stars.Add(starContainer);
            _container.Add(starContainer);
        }

        Content = _container;
        UpdateStars();
    }

    private static void OnRatingChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is StarRating starRating)
            starRating.UpdateStars();
    }

    private static void OnStarSizeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is StarRating starRating)
            starRating.UpdateStarSizes();
    }

    private static void OnStarColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is StarRating starRating)
            starRating.UpdateStarColors();
    }

    private static void OnEmptyStarColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is StarRating starRating)
            starRating.UpdateStarColors();
    }

    private void UpdateStars()
    {
        var rating = Math.Clamp(Rating, 0, 5);

        for (int i = 0; i < 5; i++)
        {
            if (_stars[i].Children.Count >= 2)
            {
                var foregroundClip = _stars[i].Children[1] as Grid;
                if (foregroundClip != null)
                {
                    double fillAmount = Math.Clamp(rating - i, 0, 1);
                    foregroundClip.WidthRequest = fillAmount * StarSize;
                }
            }
        }
    }

    private void UpdateStarSizes()
    {
        for (int i = 0; i < _stars.Count; i++)
        {
            _stars[i].WidthRequest = StarSize;
            _stars[i].HeightRequest = StarSize;

            if (_stars[i].Children[0] is Label backgroundStar)
            {
                backgroundStar.FontSize = StarSize;
            }

            if (_stars[i].Children[1] is Grid foregroundClip &&
                foregroundClip.Children[0] is Label foregroundStar)
            {
                foregroundStar.FontSize = StarSize;
                foregroundStar.WidthRequest = StarSize;
            }
        }
        UpdateStars();
    }

    private void UpdateStarColors()
    {
        foreach (var star in _stars)
        {
            if (star.Children.Count >= 2)
            {
                if (star.Children[0] is Label backgroundStar)
                    backgroundStar.TextColor = EmptyStarColor;

                if (star.Children[1] is Grid foregroundClip &&
                    foregroundClip.Children[0] is Label foregroundStar)
                    foregroundStar.TextColor = StarColor;
            }
        }
    }
}
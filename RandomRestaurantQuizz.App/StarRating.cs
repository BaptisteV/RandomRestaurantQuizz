namespace RandomRestaurantQuizz.App;

public partial class StarRating : ContentView
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

    private readonly FlexLayout _container = new()
    {
        Direction = Microsoft.Maui.Layouts.FlexDirection.Row,
    };

    private readonly List<Grid> _stars = [];

    public StarRating()
    {
        for (var i = 0; i < 5; i++)
        {
            var starContainer = new Grid
            {
                IsClippedToBounds = true,
                WidthRequest = StarSize,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill,
            };

            var backgroundStar = new Label
            {
                Text = "★",
                FontSize = StarSize,
                TextColor = EmptyStarColor,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
            };

            var foregroundClip = new Grid
            {
                IsClippedToBounds = true,
                WidthRequest = 0,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill,
            };

            var foregroundStar = new Label
            {
                Text = "★",
                FontSize = StarSize,
                TextColor = StarColor,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                WidthRequest = StarSize,
            };

            foregroundClip.Add(foregroundStar);
            starContainer.Add(backgroundStar);
            starContainer.Add(foregroundClip);

            _stars.Add(starContainer);
            _container.Add(starContainer);
        }

        var bv = new BoxView
        {
            Color = Colors.Transparent,
            Background = Colors.Transparent,
            WidthRequest = 8,
        };

        var hl = new HorizontalStackLayout
        {
            Spacing = 0,
            Children =
            {
                bv,
                _container,
            }
        };

        Content = hl;
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

        for (var i = 0; i < 5; i++)
        {
            if ((_stars[i].Children.Count >= 2) && (_stars[i].Children[1] is Grid foregroundClip))
            {
                var fillAmount = Math.Clamp(rating - i, 0, 1);
                const double adjustment = 5; // To avoid sligtly off center for 2.5
                foregroundClip.WidthRequest = fillAmount * StarSize - adjustment;
            }
        }
    }

    private void UpdateStarSizes()
    {
        for (var i = 0; i < _stars.Count; i++)
        {
            _stars[i].WidthRequest = StarSize;

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
        foreach (var star in _stars.Select(s => s.Children))
        {
            if (star.Count >= 2)
            {
                if (star[0] is Label backgroundStar)
                    backgroundStar.TextColor = EmptyStarColor;

                if (star[1] is Grid foregroundClip &&
                    foregroundClip.Children[0] is Label foregroundStar)
                    foregroundStar.TextColor = StarColor;
            }
        }
    }
}
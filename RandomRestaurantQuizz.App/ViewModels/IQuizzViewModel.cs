namespace RandomRestaurantQuizz.App.ViewModels;

public interface IQuizzViewModel
{
    int Score { get; set; }

    int ScoreDiff { get; set; }

    string LocationName { get; set; }

    byte[] ImageData { get; set; }

    bool IsLoading { get; set; }

    int SliderValue { get; set; }
}
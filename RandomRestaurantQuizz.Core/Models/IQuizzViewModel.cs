namespace RandomRestaurantQuizz.Core.Models;

public interface IQuizzViewModel
{
    int Score { get; set; }

    string ScoreDiff { get; set; }

    string LocationName { get; set; }

    ImageSource ImageSource { get; set; }

    bool IsLoading { get; set; }

    double SliderValue { get; set; }

    void Reset();
}
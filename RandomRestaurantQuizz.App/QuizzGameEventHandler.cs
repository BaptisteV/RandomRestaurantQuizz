using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.App;

internal class QuizzGameEventHandler(IServiceProvider sp) : IEventHandler
{
    public async Task PhotoChanged(QuizzModel quizz)
    {
        var s = sp.GetServices<object?>();
    }

    public async Task RoundFinished(QuizzModel quizz)
    {
    }

    public async Task ScoreChanged(QuizzModel quizz)
    {
    }
}

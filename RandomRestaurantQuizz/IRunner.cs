namespace RandomRestaurantQuizz.Console;

public interface IRunner
{
    Task RunAsync(CancellationToken cancellationToken);
}

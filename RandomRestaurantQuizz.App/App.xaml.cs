using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.App
{
    public partial class App : Application
    {
        protected readonly IQuizz _quizz;
        protected readonly ILoggerFactory _logger;
        public App(IQuizz quizz, ILoggerFactory logger)
        {
            InitializeComponent();
            _quizz = quizz;
            _logger = logger;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
namespace RandomRestaurantQuizz.App;

public partial class RecapModal : ContentPage
{
    public RecapModal(RecapViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }

    private async void CloseBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }
}
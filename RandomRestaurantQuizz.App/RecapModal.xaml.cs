namespace RandomRestaurantQuizz.App;

public class RecapModel
{

}

public partial class RecapModal : ContentPage
{
    public RecapModal()
    {
        InitializeComponent();
    }

    public RecapModal(RecapModel model)
    {
        InitializeComponent();
    }

    private async void CloseBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
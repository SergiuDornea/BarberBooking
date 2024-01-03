namespace BarberBooking;

public partial class BarberMainPage : ContentPage
{
	public BarberMainPage(int loggedInUserId)
	{
		InitializeComponent();
	}

    //  redirect to ProgramariListPage
    private async void OnViewProgramariClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProgramareListPage());
    }

    //  redirect to ClientListPage
    private async void OnViewClientsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientListPage());
    }

    // redirect to BarberListPage
    private async void OnViewBarbersClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BarberListPage());
    }
}
using BarberBooking.Auth;
namespace BarberBooking;

public partial class LogoutPage : ContentPage
{
	public LogoutPage()
	{
		InitializeComponent();
	}

    private async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        // setam isBarber to false 
        ABarber.isBarber = false;
        App.Current.MainPage = new NavigationPage(new LoginPage());
    }
}
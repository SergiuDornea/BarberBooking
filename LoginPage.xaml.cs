using BarberBooking.Auth;
using BarberBooking.Models;
namespace BarberBooking;

public partial class LoginPage : ContentPage
{
    private UserService userService = new UserService();
    public LoginPage()
	{
		InitializeComponent();
        Shell.SetTabBarIsVisible(Application.Current, false);
    }

    // logica de log in
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string parola = parolaEntry.Text;


        Barber authenticatedBarber = await userService.AuthenticateBarberAsync(email, parola);
        Client authenticatedClient = await userService.AuthenticateClientAsync(email, parola);

        if (authenticatedBarber != null)
        {
            // setam isBarber to true
            //AppShell.Current.IsBarber = true;
            //Console.WriteLine($"IsBarber value after log in: {AppShell.IsBarber}");
            // Redirect to Barber Main Page
            await Navigation.PushAsync(new BarberMainPage());
        }
        else if (authenticatedClient != null)
        {
            // setam isBarber to false
           // AppShell.Current.IsBarber = false;
            //Console.WriteLine($"IsBarber value after log in: {AppShell.IsBarber}");
            // Redirect to  Main Page
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Login nereusit", "Email sau parola invalida", "OK");
        }
    }


    private async void OnSignButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AuthPage());
    }
}
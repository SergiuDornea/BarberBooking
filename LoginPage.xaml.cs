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

        int? userId = await App.Database.GetUserIdByEmailAndPasswordAsync(email, parola);

        Barber authenticatedBarber = await userService.AuthenticateBarberAsync(email, parola);
        Client authenticatedClient = await userService.AuthenticateClientAsync(email, parola);

        if (authenticatedBarber != null)
        {
             int loggedInUserId = userId.Value;
            // setam isBarber to true
            ABarber.isBarber = true;
            //Console.WriteLine($"IsBarber value after log in: {AppShell.IsBarber}");
            // Redirect to Barber Main Page
            await Navigation.PushAsync(new BarberMainPage(loggedInUserId));
        }
        else if (authenticatedClient != null)
        {
            int loggedInUserId = userId.Value;
            // setam isBarber to false
            ABarber.isBarber = false;
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
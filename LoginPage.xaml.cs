using BarberBooking.Auth;
namespace BarberBooking;

public partial class LoginPage : ContentPage
{
    private UserService userService = new UserService();
    public LoginPage()
	{
		InitializeComponent();
	}

    // logica de log in
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string password = passwordEntry.Text;

        if (userService.AuthenticateUser(email, password))
        {
            //daca log inul e valid - redirect user la home
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
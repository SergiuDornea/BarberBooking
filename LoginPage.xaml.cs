using BarberBooking.Auth;
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

        if (userService.AuthenticateUser(email, parola))
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
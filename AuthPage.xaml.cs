using BarberBooking.Auth;
using BarberBooking.Models;
using BarberBooking.Data;
namespace BarberBooking;

public partial class AuthPage : ContentPage
{
	public AuthPage()
	{
		InitializeComponent();
        Shell.SetTabBarIsVisible(Application.Current, false);
    }

    private async void OnSignUpButtonClicked(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string parola = parolaEntry.Text;
        string nume = numeEntry.Text;
        string prenume = prenumeEntry.Text;

      
        IUser newUser = new Client { Email = email, Parola = parola, Nume = nume, Prenume = prenume  };
        await App.Database.SaveClientAsync((Client)newUser);

        //IUser newUser = new Barber { Email = email, Parola = parola, Nume = nume, Prenume = prenume };
       // await App.Database.SaveBarberAsync((Barber)newUser);

        await DisplayAlert("Sign reusit", "Cont creat+.", "OK");
        await Navigation.PushAsync(new MainPage());
    }
}
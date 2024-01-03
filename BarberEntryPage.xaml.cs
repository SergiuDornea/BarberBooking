using BarberBooking.Models;

namespace BarberBooking;

public partial class BarberEntryPage : ContentPage
{
    private Barber currentBarber;

    public BarberEntryPage()
    {
        InitializeComponent();
        currentBarber = new Barber();
    }

    public BarberEntryPage(Barber barber)
    {
        InitializeComponent();
        currentBarber = barber;
        LoadBarberDetails();
    }

    private void LoadBarberDetails()
    {
        numeEntry.Text = currentBarber.Nume;
        prenumeEntry.Text = currentBarber.Prenume;
        telefonEntry.Text = currentBarber.Telefon;
        emailEntry.Text = currentBarber.Email;
        

       
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentBarber.Nume = numeEntry.Text;
        currentBarber.Prenume = prenumeEntry.Text;
        currentBarber.Telefon = telefonEntry.Text;
        currentBarber.Email = emailEntry.Text;


        await App.Database.SaveBarberAsync(currentBarber);
        await Navigation.PopAsync();
    }

}
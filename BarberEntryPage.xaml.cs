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

        // Load other Entry fields accordingly
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentBarber.Nume = numeEntry.Text;
        currentBarber.Prenume = prenumeEntry.Text;
        currentBarber.Telefon = telefonEntry.Text;

        // Set other properties accordingly

        await App.Database.SaveBarberAsync(currentBarber);
        await Navigation.PopAsync();
    }

}
using BarberBooking.Models;


namespace BarberBooking;

public partial class ClientEntryPage : ContentPage
{
    private Client currentClient;

    public ClientEntryPage()
    {
        InitializeComponent();
        currentClient = new Client();
    }

    public ClientEntryPage(Client client)
    {
        InitializeComponent();
        currentClient = client;
        LoadClientDetails();
    }

    private void LoadClientDetails()
    {
        numeEntry.Text = currentClient.Nume;
        prenumeEntry.Text = currentClient.Prenume;
        emailEntry.Text = currentClient.Email;
        
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentClient.Nume = numeEntry.Text;
        currentClient.Prenume = prenumeEntry.Text;
        currentClient.Email = emailEntry.Text;

        await App.Database.SaveClientAsync(currentClient);
        await Navigation.PopAsync();
    }
}
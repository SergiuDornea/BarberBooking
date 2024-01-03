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
        // Load other Entry fields accordingly
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentClient.Nume = numeEntry.Text;
        // Set other properties accordingly

        await App.Database.SaveClientAsync(currentClient);
        await Navigation.PopAsync();
    }
}
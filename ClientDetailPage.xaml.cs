using BarberBooking.Models;

namespace BarberBooking;

public partial class ClientDetailPage : ContentPage
{
    private Client currentClient;

    public ClientDetailPage(Client client)
    {
        InitializeComponent();
        currentClient = client;
        BindingContext = currentClient;
    }

    private async void OnEditButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientEntryPage(currentClient));
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool isUserConfirmed = await DisplayAlert("Sterge Barber", "Esti sigur ca vrei sa stergi acest client?", "Da", "Nu");

        if (isUserConfirmed)
        {
            await App.Database.DeleteClientAsync(currentClient);
            await Navigation.PopAsync();
        }
    }
}

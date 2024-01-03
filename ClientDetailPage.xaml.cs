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
        bool isUserConfirmed = await DisplayAlert("Delete Client", "Are you sure you want to delete this Client?", "Yes", "No");

        if (isUserConfirmed)
        {
            await App.Database.DeleteClientAsync(currentClient);
            await Navigation.PopAsync();
        }
    }
}

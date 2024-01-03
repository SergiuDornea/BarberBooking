using BarberBooking.Models;

namespace BarberBooking;

public partial class ClientListPage : ContentPage
{
    public ClientListPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadClients();
    }

    private async void LoadClients()
    {
        List<Client> clients = await App.Database.GetClientsAsync();
        clientListView.ItemsSource = clients;
    }

    private async void OnAddClientClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientEntryPage());
    }

    private async void OnClientSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Client selectedClient)
        {
            await Navigation.PushAsync(new ClientDetailPage(selectedClient));
            clientListView.SelectedItem = null;
        }
    }
}
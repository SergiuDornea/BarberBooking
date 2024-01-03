using BarberBooking.Models;

namespace BarberBooking;

public partial class BarberListPage : ContentPage
{
    public BarberListPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadBarbers();
    }

    private async void LoadBarbers()
    {
        List<Barber> barbers = await App.Database.GetBarbersAsync();
        barberListView.ItemsSource = barbers;
    }

    private async void OnAddBarberClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BarberEntryPage());
    }

    private async void OnBarberSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Barber selectedBarber)
        {
            await Navigation.PushAsync(new BarberDetailPage(selectedBarber));
            barberListView.SelectedItem = null;
        }
    }
}
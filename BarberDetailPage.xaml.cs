using BarberBooking.Models;

namespace BarberBooking;

public partial class BarberDetailPage : ContentPage
{
    private Barber currentBarber;

    public BarberDetailPage(Barber barber)
    {
        InitializeComponent();
        currentBarber = barber;
        BindingContext = currentBarber;
    }

    private async void OnEditButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BarberEntryPage(currentBarber));
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool isUserConfirmed = await DisplayAlert("Delete Barber", "Are you sure you want to delete this Barber?", "Yes", "No");

        if (isUserConfirmed)
        {
            await App.Database.DeleteBarberAsync(currentBarber);
            await Navigation.PopAsync();
        }
    }
}
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
        bool isUserConfirmed = await DisplayAlert("Sterge Barber", "Esti sigur ca vrei sa stergi acest barber?", "Da", "Nu");

        if (isUserConfirmed)
        {
            await App.Database.DeleteBarberAsync(currentBarber);
            await Navigation.PopAsync();
        }
    }
}
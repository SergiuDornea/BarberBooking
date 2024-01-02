using BarberBooking.Models;

namespace BarberBooking;

public partial class ProgramareDetailPage : ContentPage
{
    private Programare currentProgramare;

    public ProgramareDetailPage(Programare programare)
    {
        InitializeComponent();
        currentProgramare = programare;
        BindingContext = currentProgramare;
    }

    private async void OnEditButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProgramareEntryPage(currentProgramare));
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool isUserConfirmed = await DisplayAlert("Delete Programare", "Are you sure you want to delete this Programare?", "Yes", "No");

        if (isUserConfirmed)
        {
            await App.Database.DeleteProgramareAsync(currentProgramare);
            await Navigation.PopAsync();
        }
    }
}

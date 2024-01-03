using BarberBooking.Models;

namespace BarberBooking;

public partial class ProgramareListPage : ContentPage
{
    

    public ProgramareListPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadProgramari();
    }

    private async void LoadProgramari()
    {
        List<Programare> programari = await App.Database.GetProgramariAsync();
        programareListView.ItemsSource = programari;
    }

    private async void OnAddProgramareClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProgramareEntryPage());
    }

    private async void OnProgramareSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Programare selectedProgramare)
        {
            await Navigation.PushAsync(new ProgramareDetailPage(selectedProgramare));
            programareListView.SelectedItem = null;
        }
    }
}


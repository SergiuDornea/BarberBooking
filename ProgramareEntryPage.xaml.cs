using BarberBooking.Models;

namespace BarberBooking;

public partial class ProgramareEntryPage : ContentPage
{
    private Programare currentProgramare;

    public ProgramareEntryPage()
    {
        InitializeComponent();
        currentProgramare = new Programare();
    }

    public ProgramareEntryPage(Programare programare)
    {
        InitializeComponent();
        currentProgramare = programare;
        LoadProgramareDetails();
    }

    private void LoadProgramareDetails()
    {
        descriereEntry.Text = currentProgramare.Descriere;
        dataDatePicker.Date = currentProgramare.Data;
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentProgramare.Descriere = descriereEntry.Text;
        currentProgramare.Data = dataDatePicker.Date;

        await App.Database.SaveProgramareAsync(currentProgramare);
        await Navigation.PopAsync();
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        await App.Database.DeleteProgramareAsync(currentProgramare);
        await Navigation.PopAsync();
    }
    
}
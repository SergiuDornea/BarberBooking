using System;
using BarberBooking.Data;
using System.IO;
namespace BarberBooking;

public partial class App : Application
{

    static BarberDatabase database;
    public static BarberDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               BarberDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "Programare.db3"));
            }
            return database;
        }
    }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

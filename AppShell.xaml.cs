using BarberBooking.Auth;
namespace BarberBooking;

public partial class AppShell : Shell
{
    // facem app shell singlketon pentru a nu 
    //private static AppShell _current;

    //public static AppShell Current
    //{
    //    get
    //    {
    //        if (_current == null)
    //            _current = new AppShell();
    //        return _current;
    //    }
    //}


    // definim isBarber pentru a vedea daca userul logat e barber - folosim asta la tabbar pt a afisa noi taburi
    //public static bool IsBarber { get; set; } = false;

    // problema necesita o propietate bindable ce se autosesizeaza cand are loc o schimbare
    public static readonly BindableProperty IsBarberProperty = BindableProperty.Create(nameof(IsBarber), typeof(bool), typeof(AppShell), false);

    public bool IsBarber
    {
        get { return (bool)GetValue(IsBarberProperty); }
        set { SetValue(IsBarberProperty, value); }
    }

    public AppShell()
	{
        //Console.WriteLine($"IsBarber value: {IsBarber}");
        IsBarber = ABarber.isBarber;
        InitializeComponent();
        
	}
}

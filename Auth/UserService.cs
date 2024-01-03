using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberBooking.Models;
using BarberBooking.Data;

namespace BarberBooking.Auth
{
    public class UserService
    {
        // o lista cu useri pt testare initiala
        //private List<IUser> users = new List<IUser>
        //{
        //    new Barber { Email = "barber@gmail.com", Parola = "parola" },
        //    new Client { Email = "client@gmail.com", Parola = "parola" },
        //};

        // verificam daca datele sunt corecte 
        //public bool AuthenticateUser(string email, string parola)
        //{
        //    return users.Any(u => u.Email == email && u.Parola == parola);
        //}

        public async Task<Barber> AuthenticateBarberAsync(string email, string password)
        {
            // Try to authenticate as a Barber
            Barber authenticatedBarber = await App.Database.AuthenticateBarberAsync(email, password);
            return authenticatedBarber;
        }

        // AuthenticateClientAsync
        public async Task<Client> AuthenticateClientAsync(string email, string password)
        {
            // Try to authenticate as a Client
            Client authenticatedClient = await App.Database.AuthenticateClientAsync(email, password);
            return authenticatedClient ;
        }

    }
}


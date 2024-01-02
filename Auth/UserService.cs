using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberBooking.Models;

namespace BarberBooking.Auth
{
    public class UserService
    {
        // o lista cu useri
        private List<IUser> users = new List<IUser>
        {
            new Barber { Email = "barber@gmail.com", Parola = "parola" },
            new Client { Email = "client@gmail.com", Parola = "parola" },
        };

        // verificam daca datele sunt corecte 
        public bool AuthenticateUser(string email, string parola)
        {
            return users.Any(u => u.Email == email && u.Parola == parola);
        }
    }
}


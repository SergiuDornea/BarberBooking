using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberBooking.Auth;

namespace BarberBooking.Models
{
    public class Client: IUser
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(50), Unique]
        public string Nume { get; set; }

        [MaxLength(50), Unique]
        public string Prenume { get; set; }


        [MaxLength(50), Unique]
        public string Parola { get; set; }


        [MaxLength(50), Unique]
        public string Email { get; set; }

    }
}

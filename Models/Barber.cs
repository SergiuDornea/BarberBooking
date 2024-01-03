using SQLite;
using System;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberBooking.Auth;

namespace BarberBooking.Models
{
    public class Barber : IUser
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50), Unique]
        public string Nume { get; set; }

        [MaxLength(50), Unique]
        public string Prenume { get; set; }

        [MaxLength(10), Unique]
        public string Telefon { get; set; }

        [MaxLength(50)]
        public string Parola { get; set; }

        [MaxLength(50), Unique]
        public string Email { get; set; }

        [MaxLength(1)]
        public int Rateing { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Programare> Programari { get; set; }

    }
}

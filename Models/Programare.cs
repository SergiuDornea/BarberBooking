using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberBooking.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100), Unique]
        public string Descriere { get; set; }
        public DateTime Data { get; set; }

        [ManyToOne]
        public Client Client { get; set; }

        // Foreign key reference to Barber
        [ForeignKey(typeof(Barber))]
        public int BarberId { get; set; }

        [ManyToOne]
        public Barber Barber { get; set; }

    }
}

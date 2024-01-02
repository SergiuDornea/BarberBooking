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

        [ForeignKey(typeof(Client))]
        public int UserId { get; set; }

    }
}

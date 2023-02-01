using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesApplication.Models
{
    public class BookingKontakt
    {
        public string BookingMail { get; set; }
        public int Bookingtelefonnummer { get; set; }

        public BookingKontakt(string bookingMail, int bookingtelefonnummer)
        {
            BookingMail = bookingMail;
            Bookingtelefonnummer = bookingtelefonnummer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesApplication.Models
{
    public class Biograf
    {
        public string Navn { get; set; }
        public string By { get; set; }

        public Biograf(string navn, string by)
        {
            Navn = navn;
            By = by;
        }
    }
}

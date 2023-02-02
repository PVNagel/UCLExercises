using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesApplication.Models
{
    public class Forestilling
    {
        public DateOnly Dato { get; set; }
        public TimeOnly Tidspunkt { get; set; }

        public Forestilling(DateOnly dato, TimeOnly tidspunkt)
        {
            Dato = dato;
            Tidspunkt = tidspunkt;
        }
    }
}

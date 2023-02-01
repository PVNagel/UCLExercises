using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesApplication.Models
{
    public class Film
    {
        public string Titel { get; set; }
        public string Genre { get; set; }
        public TimeOnly Spilletid { get; set; }
        public string Instruktør { get; set; }
        public DateOnly Præmierdato { get; set; }

        public Film(string titel, string genre, TimeOnly spilletid, string instruktør, DateOnly præmierdato)
        {
            Titel = titel;
            Genre = genre;
            Spilletid = spilletid;
            Instruktør = instruktør;
            Præmierdato = præmierdato;
        }
    }
}

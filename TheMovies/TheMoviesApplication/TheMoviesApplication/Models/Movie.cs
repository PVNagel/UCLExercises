using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesApplication.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public TimeOnly Runtime { get; set; }
        public string Director { get; set; }
        public DateOnly PremierDate { get; set; }

        public Movie(string title, string genre, TimeOnly runtime, string director, DateOnly premierDate)
        {
            Title = title;
            Genre = genre;
            Runtime = runtime;
            Director = director;
            PremierDate = premierDate;
        }
    }
}

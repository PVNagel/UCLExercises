using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMoviesApplication.Models;

namespace TheMoviesApplication.ViewModels
{
    public class MovieViewModel
    {
        private Movie movie;

        public string Title { get; set; }
        public string Genre { get; set; }
        public TimeOnly Runtime { get; set; }
        public string Director { get; set; }
        public DateOnly PremierDate { get; set; }

        public MovieViewModel(Movie movie)
        {
            this.movie = movie;
            Title = movie.Title;
            Genre = movie.Genre;
            Runtime = movie.Runtime;
            Director = movie.Director;
            PremierDate = movie.PremierDate;
        }
    }
}

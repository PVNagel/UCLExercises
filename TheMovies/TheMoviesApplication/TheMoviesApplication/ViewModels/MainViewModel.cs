using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMoviesApplication.Models;
using TheMoviesApplication.Persistens;

namespace TheMoviesApplication.ViewModels
{
    public class MainViewModel
    {
        private MovieRepository movieRepository = new MovieRepository();
        public ObservableCollection<MovieViewModel> MoviesVM { get; set; } = new();

        private MovieViewModel movieViewModel;

        public MainViewModel()
        {
            foreach (Movie movie in movieRepository.GetAll())
            {
                MovieViewModel movieVM = new(movie);
                MoviesVM.Add(movieVM);
            }
        }
    }
}

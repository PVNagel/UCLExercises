using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMoviesApplication.Models;

namespace TheMoviesApplication.Persistens
{
    public class MovieRepository
    {
        private List<Movie> movies = new List<Movie>();

        public MovieRepository()
        {
            // Read CSV file and load data
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("TheMovies.csv"))
                {
                    // Read the stream to a string, and instantiate a Person object
                    String line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] parts = line.Split(',');

                        Add(parts[3], parts[4], TimeOnly.Parse(parts[5]), parts[6], DateOnly.Parse(parts[7]));

                        //Read the next line
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public Movie Add(string titel, string genre, TimeOnly runtime, string director, DateOnly premierDate)
        {
            Movie movie = null;

            movie.Title = titel;
            movie.Genre = genre;
            movie.Runtime = runtime;
            movie.PremierDate = premierDate;
            movie.Director = director;
            movie.PremierDate = premierDate;

            movies.Add(movie);

            return movie;
        }

        public List<Movie> GetAll()
        {
            return movies;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> GetAllMovies()
        {
            var db = new DataContext();
            return db.Movies.ToList(); 
        }

        public Movie Post(Movie newMovie)
        {
            var db = new DataContext();
            db.Movies.Add(newMovie);
            db.SaveChanges();
            return newMovie;
        }

        public IEnumerable<Movie> GetMovieGenre(string genre)
        {
            var db = new DataContext();
            var horrorMovies = db.Movies.Where(movie => movie.Genre == genre);
            return horrorMovies;
        }
    }
}

//Create GET /Search? title = Jurassic that returns all movies where the title contains the title parameter

//Create a GET /Movies? genre = { Genre } that returns movies of only that Genre
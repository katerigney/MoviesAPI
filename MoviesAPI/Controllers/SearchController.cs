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
    public class SearchController : ApiController
    {
        [HttpGet]
        public Movie SearchMovie(string title)
        {
            var db = new DataContext();
            //if
            var newMovie = db.Movies.First(movie => movie.Title.Contains(title));
            return newMovie;
        }
    }
}

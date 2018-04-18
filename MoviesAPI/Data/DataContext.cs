using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MoviesAPI.Models;


namespace MoviesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Movie> Movies { get; set; }

    }
}
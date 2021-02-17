using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Controllers
{
     public class MoviesController : Controller
     {
          public ViewResult Index()
          {
               var movies = GetMovies();

               return View(movies);
          }

          private IEnumerable<Movie> GetMovies()
          {
               return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
          }

          // GET: Movies/Random
          public IActionResult Random()
          {
               var movie = new Movie() { Name = "Shrek!" };
               return View(movie);
          }
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Test2;
using Test2.Models;
using Test2.ViewModels;

namespace Test2.Controllers
{
    public class MoviesController : Controller
    {
        
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }




        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }




        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+ "/" +month);

        }



        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Test2;
using Test2.Models;
using Test2.ViewModels;
using System.Data.Entity;

namespace Test2.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }




        public ViewResult Index()
        {

            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }




        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+ "/" +month);

        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }





    }
}

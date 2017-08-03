using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies / Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            // ViewData["Movie"] = movie;                    // Not a good way of passing data
            // View Bag                                     // Not a good way
        }

        public ActionResult Customer()
        {
            var movies2 = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Wall-e"}
            };

            var customers2 = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Marry Williams"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies2[0],
                Customers = customers2
            };

            return View(viewModel);
        }

        public ActionResult CustomerDetail(string cst)
        {
            ViewBag.nameOfCst = cst;
            return View();
        }

        public ActionResult Edit(int id)           // Parameter is id.    / link / Edit / 3 will work because id is same as id in routeConfig.
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex , string sortBy)           // If want to call this method pass parameter by query string
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)         
        {
            return Content(year + "/" + month);
        }


        public ActionResult ByReleaseYear(int year, int month)          // We have make route config for this. We can call by controller name if passed by query string and call by router name if passed by paramter as /year/month
        {
            return Content(year + "/" + month);
        }
    }
}















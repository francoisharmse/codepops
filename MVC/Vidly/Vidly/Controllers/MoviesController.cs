using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Instrumentation;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    /// <summary>
    /// movies controller - this will display movie at /movies/random
    /// </summary>
    public class MoviesController : Controller
    {
        // GET: Movies
        /// <summary>
        /// gets random movies function / method - demonstrating return types
        /// </summary>
        /// <returns></returns>
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>()
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
                new Customer {Name = "Customer 3"},
                new Customer {Name = "Customer 4"},
                new Customer {Name = "Customer 5"},
                new Customer {Name = "Customer 6"},
                new Customer {Name = "Customer 7"},
                new Customer {Name = "Customer 8"}
            };

            var viewModel = new RandomMovieViewModel { Movie = movie, Customers = customers };

            //this is the object passed to "Random.cshtml View inside @model Vidly.Models.Movie
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        /// <summary>
        /// just added a new actionresult when calling /movies/random
        /// </summary>
        /// <param name="id">input id to page</param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        /// <summary>
        /// renders simple content of pageindex and sorBy parameters which had been passed in
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        /// <summary>
        /// demonstrating routes inside the controller - this is referencing the routes.MapMvcAttributeRoutes(); statement inside Routes.Config.cs
        /// </summary>
        /// <param name="year">year parameter must be 4 digits long because regex, and between 1800 and 2100</param>
        /// <param name="month">month must be 2 digits long because of regex and must be between 1 and 12</param>
        /// <returns></returns>
        [Route("movies/released/{year:regex(\\d{4}:range(1800, 2100))}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(string.Format("{0}/{1}", year, month));
        }
    }
}
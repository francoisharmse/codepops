using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Instrumentation;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Vidly.Controllers
{
    /// <summary>
    /// movies controller - this will display movie at /movies/random
    /// </summary>
    public class MoviesController : Controller
    {
        private ApplicationDbContext _dbContext;

        ///// <summary>
        ///// created a public static list of movies so that other code can use the same list of movies
        ///// </summary>
        //public static List<Movie> movies = new List<Movie>()
        //{
        //    new Movie {Name = "Shrek 1"},
        //    new Movie {Name = "Shrek 2"},
        //    new Movie {Name = "Bold and the Beautiful"},
        //    new Movie {Name = "Shark Tail 1"},
        //    new Movie {Name = "Shark Tail 2"},
        //    new Movie {Name = "Pink Panther"},
        //    new Movie {Name = "Black Beauty"},
        //    new Movie {Name = "Once more"},
        //    new Movie {Name = "Die hard 1"},
        //    new Movie {Name = "Die hard 2"},
        //    new Movie {Name = "Die hard 3"},
        //    new Movie {Name = "Die hard 4"},
        //    new Movie {Name = "Die hard 5"},
        //    new Movie {Name = "Fast and Furious 1"},
        //    new Movie {Name = "Fast and Furious 2"},
        //    new Movie {Name = "Fast and Furious 3"},
        //    new Movie {Name = "Fast and Furious 4"},
        //    new Movie {Name = "Fast and Furious 5"},
        //    new Movie {Name = "Fast and Furious 6"}
        //};


        /// <summary>
        /// Default constructor - constructing db context
        /// </summary>
        public MoviesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        /// <summary>
        /// Dispose DB Context
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        // GET: Movies
        /// <summary>
        /// gets random movies function / method - demonstrating return types
        /// </summary>
        /// <returns></returns>
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //use list of customers already defined in CustomerController
            var customers = CustomersController.GetCustomers();

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
            var movie = _dbContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                MovieGenres = _dbContext.MovieGenreTypes.ToList()
            };

            return View("MovieForm", viewModel);
        }

        /// <summary>
        /// Save Movie
        /// </summary>
        /// <param name="movie">movie object</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Today;
                _dbContext.Movies.Add(movie);
            }
            else
            {
                var moviesInDb = _dbContext.Movies.FirstOrDefault(m => m.Id == movie.Id);

                moviesInDb.Name = movie.Name;
                moviesInDb.DateAdded = movie.DateAdded;
                moviesInDb.MovieGenreId = movie.MovieGenreId;
                moviesInDb.ReleaseDate = movie.ReleaseDate;
                moviesInDb.StockCount = movie.StockCount;
            }

            _dbContext.SaveChanges();

            return RedirectToAction("ListMovies", "Movies");
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

        /// <summary>
        /// GET: List Movies
        /// </summary>
        /// <returns></returns>
        public ActionResult ListMovies()
        {
            var listAllMovies = new ListAllMoviesViewModel { Movies = _dbContext.Movies.Include(m => m.MovieGenre).ToList() };

            return View(listAllMovies);
        }

        /// <summary>
        /// Get Movie Detail - including Genre which is foreign key linked table
        /// </summary>
        /// <param name="id">id of movie</param>
        /// <returns></returns>
        [Route("movie/details/{id}")]
        public ActionResult Details(int id)
        {
            //get movie detail from DB, with Include which links the Genre table / object
            var movieDetail = new DetailMovieViewModel() { Movie = _dbContext.Movies.Include(c => c.MovieGenre).SingleOrDefault(customer => customer.Id == id) };
            return View(movieDetail);
        }

        /// <summary>
        /// Create a new movie object from a form
        /// </summary>
        /// <returns></returns>
        public ActionResult New()
        {
            var genres = _dbContext.MovieGenreTypes.ToList();
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                MovieGenres = genres
            };

            return View("MovieForm", viewModel);
        }
    }
}
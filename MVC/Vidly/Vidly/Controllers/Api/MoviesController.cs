using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Instrumentation;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    /// <summary>
    /// movies controller - this will display movie at /movies/random
    /// </summary>
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();  
        }

        /// <summary>
        /// GET /api/Movies
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        /// <summary>
        /// GET /api/Movies/1
        /// </summary>
        /// <param name="id">pass in ID for movieDto</param>
        /// <returns></returns>
        public IHttpActionResult GetMovie(int id)
        {
            var Movie = _context.Movies.FirstOrDefault(m => m.Id == id);

            if (Movie == null)
                return NotFound();
            //throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<Movie, MovieDto>(Movie));
        }

        /// <summary>
        /// POST /api/Movies
        /// </summary>
        /// <param name="movieDtoDto"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            //throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            movie.DateAdded = DateTime.Now;

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        /// <summary>
        /// PUT /api/movieDto/1
        /// </summary>
        /// <param name="id">the movieDto ID</param>
        /// <param name="movieDtoDto"></param>
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            //throw new HttpResponseException(HttpStatusCode.BadRequest);

            var MovieInDb = _context.Movies.FirstOrDefault(c => c.Id == id);

            if (MovieInDb == null)
                return NotFound();
            //throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, MovieInDb);

            //lines below were replaced by above statement
            //MovieInDb.Name = movieDto.Name;
            //MovieInDb.BirthDate = movieDto.BirthDate;
            //MovieInDb.IsSubScribedToNewsLetter = movieDto.IsSubScribedToNewsLetter;
            //MovieInDb.MembershipTypeId = movieDto.MembershipTypeId;

            _context.SaveChanges();

            return StatusCode(HttpStatusCode.Accepted);
        }

        /// <summary>
        /// DELETE /api/movieDto/1
        /// </summary>
        /// <param name="id">ID of movieDto</param>
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var MovieInDb = _context.Movies.FirstOrDefault(c => c.Id == id);

            if (MovieInDb == null)
                return NotFound();
            //throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(MovieInDb);
            _context.SaveChanges();

            return StatusCode(HttpStatusCode.Accepted);
        }
    }
}
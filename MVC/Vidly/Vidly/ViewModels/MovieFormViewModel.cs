using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{

    /// <summary>
    /// Movie Form View Model
    /// </summary>
    public class MovieFormViewModel
    {
        /// <summary>
        /// list of movie genres
        /// </summary>
        public IEnumerable<MovieGenre> MovieGenres { get; set; }

        /// <summary>
        /// Movie Object
        /// </summary>
        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Ëdit Movie";

                return "New Movie";
            }
        }
    }
}
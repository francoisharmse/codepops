using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    /// <summary>
    /// controller listing all moving
    /// </summary>
    public class ListAllMoviesViewModel
    {
        /// <summary>
        /// listing all movies
        /// </summary>
        public List<Movie> Movies { get; set; }
    }
}
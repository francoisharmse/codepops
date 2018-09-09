using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    /// <summary>
    /// Movie model (POCO)
    /// </summary>
    public class Movie
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        /// <summary>
        /// set movie genre
        /// </summary>
        public MovieGenre MovieGenre { get; set; }

        /// <summary>
        /// number of movies in stock
        /// </summary>
        public byte StockCount { get; set; }

        /// <summary>
        /// Movie release date
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Date when movie was added to shop
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    /// <summary>
    /// movie Data transfer Object
    /// </summary>
    public class MovieDto
    {
        public int Id { get; set; }

        /// <summary>
        /// name of movie
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// set movie genre
        /// </summary>
        public MovieGenre MovieGenre { get; set; }

        /// <summary>
        /// movie genre id
        /// </summary>
        [Required]
        public byte MovieGenreId { get; set; }

        /// <summary>
        /// number of movies in stock
        /// </summary>
        [Required]
        [Range(1, 20)]
        public byte StockCount { get; set; }

        /// <summary>   
        /// Movie release date
        /// </summary>
        [Required]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Date when movie was added to shop
        /// </summary>
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
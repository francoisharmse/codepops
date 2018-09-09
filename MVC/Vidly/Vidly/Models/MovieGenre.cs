using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    /// <summary>
    /// genre master data 
    /// </summary>
    public class MovieGenre
    {
        /// <summary>
        /// set genre id 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        /// <summary>
        /// specify genre names
        /// </summary>
        public string GenreDescription { get; set; }

        /// <summary>
        /// value of type of genre
        /// </summary>
        public byte GenreType { get; set; }
    }
}
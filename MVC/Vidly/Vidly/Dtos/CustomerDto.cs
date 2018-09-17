using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    /// <summary>
    /// Customer Dto (Data Transfer Object)
    /// </summary>
    public class CustomerDto
    {
        public int Id { get; set; }
        /// <summary>
        /// name attribute (column) now changed to be notnull, and varchar(255)
        /// 
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSubScribedToNewsLetter { get; set; }

        /// <summary>
        /// entity framework identifies this convention and treats this as a foreign key property
        /// </summary>
        public byte MembershipTypeId { get; set; }

        /// <summary>
        /// set birthdate - this field is optional
        /// </summary>
        //[Min18YrsIfAMemeber]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// membershiptype Data Transfer Object
        /// </summary>
        public MembershipTypeDto MemberShipType { get; set; }
    }
}
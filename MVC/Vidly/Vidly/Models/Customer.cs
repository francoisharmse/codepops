﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    /// <summary>
    /// customer class 
    /// </summary>
    public class Customer
    {
        public int  Id { get; set; }
        public string  Name { get; set; }
        public bool IsSubScribedToNewsLetter { get; set; }

        /// <summary>
        /// navigational property - linking customer and the type of customer it is together
        /// </summary>
        public MemberShipType MemberShipType { get; set; }

        /// <summary>
        /// entity framework identifies this convention and treats this as a foreign key property
        /// </summary>
        public byte MembershipTypeId { get; set; }

    }
}
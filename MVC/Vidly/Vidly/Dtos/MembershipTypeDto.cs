using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MembershipTypeDto
    {
        /// <summary>
        /// this is the ID or key property on this table / class type
        /// </summary>
        public byte Id { get; set; }

        /// <summary>
        /// a description of the membership type
        /// </summary>
        public string MemberShipTypeName { get; set; }

    }
}
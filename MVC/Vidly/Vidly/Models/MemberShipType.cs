using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    /// <summary>
    /// this is a membership type class - types of members in our video store
    /// </summary>
    public class MemberShipType
    {
        /// <summary>
        /// this is the ID or key property on this table / class type
        /// </summary>
        public byte Id { get; set; }

        /// <summary>
        /// signup fee - wount have many customers (will be less than 32,000)
        /// </summary>
        public short SignUpFee { get; set; }

        /// <summary>
        /// signup period in months
        /// </summary>
        public byte DurationMonths { get; set; }

        /// <summary>
        /// discount rate for customer
        /// </summary>
        public byte Discount { get; set; }

        /// <summary>
        /// a description of the membership type
        /// </summary>
        public string MemberShipTypeName { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 0;
    }
}
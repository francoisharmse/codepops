using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    /// <summary>
    /// controller listing all customers
    /// </summary>
    public class ListAllCustomersViewModel
    {
        /// <summary>
        /// listing all customers
        /// </summary>
        public List<Customer> Customers { get; set; }
    }
}
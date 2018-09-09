using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Instrumentation;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    /// <summary>
    /// movies controller - this will display movie at /movies/random
    /// </summary>
    public class CustomersController : Controller
    {

        /// <summary>
        /// created a public static list of customers for now - so that other code can use the same list of customers.
        /// </summary>
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer {Id = 6, Name = "John Doe"},
            new Customer {Id = 1, Name = "Sarah Mary"},
            new Customer {Id = 2, Name = "James May"},
            new Customer {Id = 3, Name = "Robert James"},
            new Customer {Id = 4, Name = "Brenda May"},
            new Customer {Id = 5, Name = "Frik Slabbert"}
        };

        /// <summary>
        /// GET: List Customers
        /// </summary>
        /// <returns></returns>
        public ActionResult ListCustomers()
        {
            var listAllCustomers = new ListAllCustomersViewModel { Customers = customers };

            return View(listAllCustomers);
        }

        /// <summary>
        /// details of customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("customer/details/{id}")]
        public ActionResult Details(int id)
        {
            if (id > customers.Count || id < 1)
                return HttpNotFound();

            var customerDetail = new DetailCustomerViewModel() { Customer = customers.Find(customer => customer.Id == id) };
            return View(customerDetail);
        }
    }


}
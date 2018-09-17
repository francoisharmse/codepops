using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Instrumentation;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    /// <summary>
    /// movies controller - this will display movie at /movies/random
    /// </summary>
    public class CustomersController : Controller
    {

        /// <summary>
        /// creating a db context
        /// </summary>
        private ApplicationDbContext _dbContext;

        public CustomersController()
        {
            _dbContext = new ApplicationDbContext();
        }

        /// <summary>
        /// properly disposing of _dbContext
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        /// <summary>
        /// Add new customer form
        /// </summary>
        /// <returns></returns>
        public ActionResult New()
        {
            var membershipTypes = _dbContext.MemberShipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                MemberShipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }


        /// <summary>
        /// saving the customer form
        /// </summary>
        /// <param name="customer">customer object </param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MemberShipTypes = _dbContext.MemberShipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
                _dbContext.Customers.Add(customer);
            else
            {
                var customerInDb = _dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDate= customer.BirthDate;
                customerInDb.IsSubScribedToNewsLetter= customer.IsSubScribedToNewsLetter;
                customerInDb.MembershipTypeId= customer.MembershipTypeId;
            }
            //_dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();

            return RedirectToAction("ListCustomers", "Customers");
        }

        public static List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer {Id = 6, Name = "John Doe"},
                new Customer {Id = 1, Name = "Sarah Mary"},
                new Customer {Id = 2, Name = "James May"},
                new Customer {Id = 3, Name = "Robert James"},
                new Customer {Id = 4, Name = "Brenda May"},
                new Customer {Id = 5, Name = "Frik Slabbert"}
            };
        }

        /// <summary>
        /// GET: List Customers
        /// </summary>
        /// <returns></returns>
        public ActionResult ListCustomers()
        {
            //this was using the hardcoded customer list above
            //var listAllCustomers = new ListAllCustomersViewModel { Customers = GetCustomers() };

            //now using the DB context
            //by calling the toList() now - EntityFramework executes the query
            //else it would only have executed in the View method.
            //var listAllCustomers = _dbContext.Customers.ToList();

            //var listAllCustomers = new ListAllCustomersViewModel { Customers = _dbContext.Customers.Include(c => c.MemberShipType).ToList() };

            return View();
        }

        /// <summary>
        /// details of customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("customer/details/{id}")]
        public ActionResult Details(int id)
        {
            //check if id is within the number of records in the DB (number of customers)
            if (id > _dbContext.Customers.Count() + 1 || id < 1)
                return HttpNotFound();

            var customerDetail = new DetailCustomerViewModel() { Customer = _dbContext.Customers.Include(c => c.MemberShipType).SingleOrDefault(customer => customer.Id == id) };
            return View(customerDetail);
        }

        /// <summary>
        /// edit a customer
        /// </summary>
        /// <param name="id">insert ID of customer</param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MemberShipTypes = _dbContext.MemberShipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }


}
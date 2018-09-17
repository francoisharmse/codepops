using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Vidly.Dtos;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        /// <summary>
        /// GET /api/customers
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers.Include(m => m.MemberShipType).ToList().Select(Mapper.Map<Customer, CustomerDto>);
            //var customers = _context.Customers.Include(m => m.MemberShipType).ToList();

            return Ok(customerDtos);
        }

        /// <summary>
        /// GET /api/customers/1
        /// </summary>
        /// <param name="id">pass in ID for customerDto</param>
        /// <returns></returns>
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.Include(c => c.MemberShipType).FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();
            //throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        /// <summary>
        /// POST /api/customers
        /// </summary>
        /// <param name="customerDto"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            //throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        /// <summary>
        /// PUT /api/customerDto/1
        /// </summary>
        /// <param name="id">the customerDto ID</param>
        /// <param name="customerDto"></param>
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            //throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.FirstOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();
            //throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDto, customerInDb);

            //lines below were replaced by above statement
            //customerInDb.Name = customerDto.Name;
            //customerInDb.BirthDate = customerDto.BirthDate;
            //customerInDb.IsSubScribedToNewsLetter = customerDto.IsSubScribedToNewsLetter;
            //customerInDb.MembershipTypeId = customerDto.MembershipTypeId;

            _context.SaveChanges();

            return StatusCode(HttpStatusCode.Accepted);
        }

        /// <summary>
        /// DELETE /api/customerDto/1
        /// </summary>
        /// <param name="id">ID of customerDto</param>
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.FirstOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();
            //throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return StatusCode(HttpStatusCode.Accepted);
        }
    }
}

/*
    Author: Jacob Storer
    Date: 08/11/2019
    Description: Movie Rental Application
    Framework: ASP.NET
    Uses: Razor, MVC, Entity Framework, MySQL Database, Lambda Expressions
*/

/* Imports */
using System;
using System.Data.Entity; // Dont forget to add this
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // Declare type of DbContext for variable _context
        private ApplicationDbContext _context; // Gateway to access Database

        public CustomersController()
        {
            _context = new ApplicationDbContext(); // Assign DbContext to gateway
        } // End --CustomersController()

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); // _context is disposible.. so dispose of it
        } // End -- Dispose(bool disposing)

        // Route Constraints
        [Route("customers/details/{id}")] // Looking for any value at {id}

        // Get target customers values
        public ActionResult Details(int id)
        {
            // Input: id - used for targetting appropriate customer values;
            // Processing: Determine which customer value to output;
            // Output: Context about specific customer ( URL: ~/Customers/Details/{id} );

            /* Notes: id = target appropriate customer name */

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id); // Append Class of MembershipType to customers; Display only one record or default value; Evalute (Customers.Id == id)

            if (customer == null) // Default value passed back?
                return HttpNotFound(); // Customer not found

            return View(customer); // Return context of specific customer
        } // End -- ActionResult Details()

        // Get listing of Customers 
        public ActionResult Index()
        {
            // Input: None;
            // Processing: Get values from database of Customers table;
            // Output: Context of Customers table in database ( URL: ~/Customers/ )

            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); // Append Class of MembershipType to customers; Executes immediately;

            return View(customers); // Return context of database
        } // End -- ActionResult Index()
    } // End -- CustomersController : Controller
} // End -- namespace Vidly.Controllers
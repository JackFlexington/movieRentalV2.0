/*
    Filename: CustomersController.cs
    Author: Jacob Storer
    Date: 08/09/2019
    Description: Movie Rental Application
    Framework: ASP.NET
    Uses: Razor, MVC, ViewModels & Models
*/

/* Imports */
using System;
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
        // Route Constraints
        [Route("customers/details/{id}")] // Looking for any value at {id}

        // Get target customers values
        public ActionResult Target(int id)
        {
            // Input: id - used for targetting appropriate customer values;
            // Processing: Determine which customer value to output;
            // Output: Display information about customer ( URL: ~/Customers/Details/{id} )

            /* Notes:
                id = target appropriate customer name
            */
            
            // Determine appropriate customer values
            if (id == 1) // FOUND
            {
                return View("JohnSmith"); // Output name based on id
            }
            else if (id == 2) // FOUND
            {
                return View("MaryWilliams"); // Output name based on id
            }
            else // NOT FOUND
            {
                return HttpNotFound(); // Display generic 404 page
            }
        } // End -- ActionResult Target()

        // Get listing of Customers 
        public ActionResult Default()
        {
            // Input: None;
            // Processing: Assign newly created Object(Customer) values of Customers names and Id's;
            // Assign Object(Customer) to Objects' List<Customer> structure;
            // Output: Values used to insert into <table> on webpage ( URL: ~/Customers/ )

            // Variable to hold an 'array' of values.
            var customers = new List<Customer>
            {
                // Insert values into 'array'
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2}
            };
            
            // Variable to store structure
            var viewModel = new CustomerViewModel
            {
                Customers = customers // Insert values into structure
            };

            return View(viewModel); // Return data structure used to show all customers.
        } // End -- ActionResult Default()
    } // End -- CustomersController : Controller
} // End -- namespace Vidly.Controllers
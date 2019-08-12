/*
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
using Vidly.Models;

namespace Vidly.ViewModels
{
    // Initialize structure for CustomerViewModel -- Add setters & getters
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
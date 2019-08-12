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

namespace Vidly.Models
{
    // Initialize structure for Customer -- Add setters & getters
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
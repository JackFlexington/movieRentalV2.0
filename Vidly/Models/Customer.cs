/*
    Author: Jacob Storer
    Date: 08/11/2019
    Description: Movie Rental Application
    Framework: ASP.NET
    Uses: Razor, MVC, Entity Framework, MySQL Database, Lambda Expressions
*/

/* Imports */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Dont forget to add
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    // Initialize structure for Customer -- Add setters & getters
    public class Customer
    {
        // Class Structure
        public int Id { get; set; } // key for Customer class
        [Required] // Name column is no longer nullible
        [StringLength(255)] // Max length of Name column
        public string Name { get; set; } // Customer Name
        public bool IsSubscribedToNewsLetter { get; set; } // Subscribed?
        public byte MembershipTypeId { get; set; } // Foreign key
        public DateTime? Birthdate { get; set; } // Birthdate -- Optional (Nullifible)

        // Class within Class
        public MembershipType MembershipType { get; set; } // Membership Class
    }
}
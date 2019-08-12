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
    // Initialize structure for Movie -- Add setters & getters
    public class Movie
    {
        public int Id { get; set; } // Movie Id
        [Required] // Name column is no longer nullible
        [StringLength(255)] // Max length of Name column
        public string Name { get; set; } // Movie Name
        public byte GenreTypeId { get; set; } // Foreign Key
        public DateTime DateAdded { get; set; } // Added to database
        public DateTime ReleaseDate { get; set; } // Release date of movie
        public byte NumberInStock { get; set; } // Inventry Count

        // Class within Class
        public GenreType GenreType { get; set; } // GenreType Class
    }
}
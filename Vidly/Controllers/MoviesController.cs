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
    public class MoviesController : Controller
    {
        // Declare type of DbContext for variable _context
        private ApplicationDbContext _context; // Gateway to access Database

        public MoviesController()
        {
            _context = new ApplicationDbContext(); // Assign DbContext to gateway
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); // _context is disposible.. so dispose of it
        }
     
        // Route Constraints
        [Route("movies/details/{id}")] // Looking for any value at {id}

        // Get target movies values
        public ActionResult Details(int id)
        {
            // Input: id - used for targetting appropriate Movie values;
            // Processing: Determine which Movie value to output;
            // Output: Context about specific Movie ( URL: ~/Movies/Details/{id} );

            /* Notes:
                id = target appropriate movie name
            */

            var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id); // Append Class of MembershipType to movies; Display only one record or default value; Evalute (movies.Id == id)

            if (movie == null) // Default value passed back?
                return HttpNotFound(); // Movie not found

            return View(movie); // Return context of specific movie
        } // End -- ActionResult Details()

        // Get listing of Movies 
        public ActionResult Index()
        {
            // Input: None;
            // Processing: Get values from database of Movies table;
            // Output: Context of Movies table in database ( URL: ~/Movies/ )

            var movies = _context.Movies.Include(m => m.GenreType).ToList(); // Append Class of MembershipType to movies; Executes immediately;

            return View(movies); // Return context of database
        } // End -- ActionResult Index()
    } // End -- MoviesController : Controller
} // End -- namespace Vidly.Controllers
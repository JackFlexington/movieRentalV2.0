/*
    Filename: MoviesController.cs
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
    public class MoviesController : Controller
    {
        // GET: Movies / Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer { Name = "Customer 1"},
        //        new Customer { Name = "Customer 2"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //    // return View(movie);
        //    // return Content("Hello world");
        //    // return HttpNotFound();
        //    // return new EmptyResult();
        //    // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        //}

        // Route Constraints
        [Route("movies/details/{id}")]

        // Get target movies values
        public ActionResult TargetMovie(int id)
        {
            // Input: id - used for targetting appropriate Movie values;
            // Processing: Determine which Movie value to output;
            // Output: Display information about Movie ( URL: ~/Movies/Details/{id} )

            /* Notes:
                id = target appropriate movie name
            */

            // Determine appropriate customer values
            if (id == 1) // FOUND
            {
                return View("Shrek"); // Output name based on id
            }
            else if (id == 2) // FOUND
            {
                return View("Walle"); // Output name based on id
            }
            else // NOT FOUND
            {
                return HttpNotFound(); // Display generic 404 page
            }
        } // End -- ActionResult TargetMovie()

        // Get listing of Movies 
        public ActionResult Movies()
        {
            // Input: None;
            // Processing: Assign newly created Object(Movie) values of Movies names and Id's;
            // Assign Object(Movie) to Objects' List<Movie> structure;
            // Output: Values used to insert into <table> on webpage ( URL: ~/Movies/ )

            // Variable to hold an 'array' of values.
            var movies = new List<Movie>
            {
                // Insert values into 'array'
                new Movie { Name = "Shrek", Id = 1},
                new Movie { Name = "Wall-e", Id = 2}
            };

            // Variable to store structure
            var viewModel = new MoviesViewModel
            {
                Movies = movies // Insert values into structure
            };

            return View(viewModel); // Return data structure used to show all movies.
        } // End -- ActionResult Movies()

        //// Route Constraints
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}       
    } // End -- MoviesController : Controller
} // End -- namespace Vidly.Controllers
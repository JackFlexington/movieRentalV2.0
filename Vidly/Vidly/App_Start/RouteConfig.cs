/*
    Author: Jacob Storer
    Date: 08/09/2019
    Description: Movie Rental Application
    Framework: ASP.NET
    Uses: Razor, MVC, ViewModels & Models

    Notes from Developer:
     -- [Make retrieving information better]Using GET could make routing determination 
        both easier and better... 
        The reason it'd be better is because currently calling a file created within 
        the /View/{Customers|Movies} directory rather than acquiring GET information
        generated from the ActionLinks...
        When database gets implemented I will flesh out the retrieval of information at
        that time...
*/

/* Imports */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes) // "routes" of Class RouteCollection
        {
            // routes = object of class
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // Stops ASP.NET from hanlding HTTP requests -- Allows HttpHandler to... well handle the request

            routes.MapMvcAttributeRoutes(); // Call Attribute Routing -- Useful for URI constraints

            // Convention Routing - Also not recommended standard
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}", // Target URL
            //    new { controller = "Movies", action = "ByReleaseDate" }, // Key of value pairs
            //    // new { year = @"\d{4}", month = @"\d{2}" }); // Sub-directories that require 4-digit year and 2-digit month
            //    new { year = @"2015|2016", month = @"\d{2}" }); // Sub-directories that require value to be either 2015 or 2016 and 2-digit month

            // Display specific Customer
            routes.MapRoute(
                "TargetCustomer", // Route Name
                "customers/details/{id}", // Target URL
                new { controller = "Customers", action = "Target"}, // Parameter Defaults
                new { id = @"1|2" } // Require id to be 1 or 2
                ); // END -- Display specific Customer

            // Display all Customers
            routes.MapRoute(
                "Customers", // Route Name
                "customers", // URL
                new { controller = "Customers", action = "Default" } // Parameter Defaults
                ); // END -- Display all Customers

            // Display specific Movie
            routes.MapRoute(
                "TargetMovie", // Route Name
                "movies/details/{id}", // URL w/ parameters
                new { controller = "Movies", action = "TargetMovie" } // Parameter Defaults
                ); // END -- Display specific Movie

            // Display all Movies
            routes.MapRoute(
                "Movies", // Route Name
                "movies", // URL
                new { controller = "Movies", action = "Movies" } // Parameter Defaults
                ); // END -- Display all Movies 


            // Default Routing
            routes.MapRoute(
                name: "Default", // Route Name
                url: "{controller}/{action}/{id}", // URL w/ parameters
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter Defaults -- id is optional
            ); // END -- Default Routing
        } // END -- RegisterRoutes(RouteCollection routes)
    } // END -- public class RouteConfig
} // END -- namespace Vidly

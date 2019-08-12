/*
    Author: Jacob Storer
    Date: 08/11/2019
    Description: Movie Rental Application
    Framework: ASP.NET
    Uses: Razor, MVC, Entity Framework, MySQL Database, Lambda Expressions

    Notes from Developer:
     -- 
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

            // Display specific Customer
            routes.MapRoute(
                "TargetCustomer", // Route Name
                "customers/details/{id}", // Target URL
                new { controller = "Customers", action = "Details"} // Parameter Defaults
                // new { id = @"1|2" } // Require id to be 1 or 2
                ); // END -- Display specific Customer

            // Display all Customers
            routes.MapRoute(
                "Customers", // Route Name
                "customers", // URL
                new { controller = "Customers", action = "Index" } // Parameter Defaults
                ); // END -- Display all Customers

            // Display specific Movie
            routes.MapRoute(
                "TargetMovie", // Route Name
                "movies/details/{id}", // URL w/ parameters
                new { controller = "Movies", action = "Details" } // Parameter Defaults
                ); // END -- Display specific Movie

            // Display all Movies
            routes.MapRoute(
                "Movies", // Route Name
                "movies", // URL
                new { controller = "Movies", action = "Index" } // Parameter Defaults
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

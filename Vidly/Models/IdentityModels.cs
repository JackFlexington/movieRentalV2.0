/*
    Author: Jacob Storer
    Date: 08/11/2019
    Description: Movie Rental Application
    Framework: ASP.NET
    Uses: Razor, MVC, Entity Framework, MySQL Database, Lambda Expressions
*/

/* Imports */
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // Gateway to database - derives from IdentityDbContext<ApplicationUser>
    {
        // Includes into Migrations
        public DbSet<Customer> Customers { get; set; } // Makes DbContext aware of Customer Class.
        public DbSet<Movie> Movies { get; set; } // Makes DbContext aware of Movie Class.

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
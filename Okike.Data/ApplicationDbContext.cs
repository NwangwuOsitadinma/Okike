using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Okike.Model;
using System.Data.Entity;
using System;
using Okike.Data.Configuration;

namespace Okike.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<FoodItem> FootItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodGroup> FoodGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FoodItemConfiguration());
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
    }
}
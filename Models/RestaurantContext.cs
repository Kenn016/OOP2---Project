using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestaurantMaster.Models
{
    public class RestaurantContext : DbContext
    {
        // DbSets for each entity representing tables in the database
        public DbSet<Customer> Customers { get; set; }  // Represents the Customers table in the database
        public DbSet<Employee> Employees { get; set; }  // Represents the Employees table in the database
        public DbSet<MenuItem> MenuItems { get; set; }  // Represents the MenuItems table in the database
        public DbSet<Order> Orders { get; set; }  // Represents the Orders table in the database
        public DbSet<Reservation> Reservations { get; set; }  // Represents the Reservations table in the database
        public DbSet<Payment> Payments { get; set; }  // Represents the Payments table in the database
        public DbSet<Table> Tables { get; set; }  // Represents the Tables table in the database

        // Configures the database connection using a connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Set up the connection string to the database
            optionsBuilder.UseSqlServer("YourConnectionString");  // Replace with your actual connection string
        }
    }
}

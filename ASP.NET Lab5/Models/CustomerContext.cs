using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Lab5.Models
{
    public class CustomerContext : DbContext
    {
        //constructor for my DB context class
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        //I am making database list for my framework here of my models
        public DbSet<Customer> Customers { get; set; }
        //This is the database for my another model that is orders
        public DbSet<Order> Orders { get; set; }
        
    }
}

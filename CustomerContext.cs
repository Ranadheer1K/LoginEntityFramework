using LoginEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginEntityFramework
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=customerDbConnectionString")
        {

        }

        public DbSet<Customer> customers { get; set; }
    }
}
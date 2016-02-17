using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Anz.Web.Models
{
    public class AnzDb : DbContext
    {
        public AnzDb() : base("name=DefaultConnection")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
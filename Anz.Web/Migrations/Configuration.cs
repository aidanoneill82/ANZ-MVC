namespace Anz.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Anz.Web.Models;
    using System.Collections.Generic;


    internal sealed class Configuration : DbMigrationsConfiguration<Anz.Web.Models.AnzDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Anz.Web.Models.AnzDb";
        }

        protected override void Seed(Anz.Web.Models.AnzDb context)
        {
            ICollection<Loan> davidsLoans = new List<Loan>();

            Loan loan1 = new Loan();
            loan1.Id = 1;
            loan1.Amount = 1000000;
            loan1.Interest = .05;
            davidsLoans.Add(loan1);

            Loan loan2 = new Loan();
            loan2.Id = 2;
            loan2.Amount = 500000;
            loan2.Interest = .045;
            davidsLoans.Add(loan2);

            ICollection<Loan> janetsLoans = new List<Loan>();

            Loan loan3 = new Loan();
            loan3.Id = 3;
            loan3.Amount = 1000000;
            loan3.Interest = .05;
            janetsLoans.Add(loan3);

            Loan loan4 = new Loan();
            loan4.Id = 4;
            loan4.Amount = 500000;
            loan4.Interest = .045;
            janetsLoans.Add(loan4);

            context.Loans.AddOrUpdate(l => l.Id,
               loan1,
               loan2,
               loan3,
               loan4
               );

            context.Customers.AddOrUpdate(c => c.Email,
                new Customer { FirstName = "Janet", LastName = "Mu", Email = "janet.mu@anzmortgagesolutions.com", Loans = janetsLoans},
                new Customer { FirstName = "David", LastName = "Suluva", Email = "david.suluva@anzmortgagesolutions.com", Loans = davidsLoans }
                );

            for (int i = 0; i < 1000; i++)
            { 
                context.Customers.Add(
                    new Customer { FirstName = "Customer" + i.ToString(), LastName = "Customer" + i.ToString(), Email = "customer" + i.ToString() + "@anzmortgagesolutions.com", Loans = new List<Loan>() }
                    );
            }
        }
       
    }
}

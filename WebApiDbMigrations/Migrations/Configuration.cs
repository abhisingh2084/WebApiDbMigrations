namespace WebApiDbMigrations.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiDbMigrations.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiDbMigrations.DataBaseHelpers.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiDbMigrations.DataBaseHelpers.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var Employees = new List<Employee>
            {
                new Employee { FirstName = "abhishek", LastName = "Kumar", Gender = "Male", City = "Hyderabad"},
                new Employee { FirstName = "Neha", LastName = "Singh", Gender = "Female", City = "JaiPur"},
                new Employee { FirstName = "Sahil", LastName = "Kumar", Gender = "Male", City = "Pune"},
                new Employee { FirstName = "ShashiKant", LastName = "Kumar", Gender = "Male", City = "JabalPur"},
                new Employee { FirstName = "Ramcharan", LastName = "kale", Gender = "Male", City = "Shimla"},
                new Employee { FirstName = "Deepak", LastName = "Kumar", Gender = "Male", City = "Noida"},
            };

            Employees.ForEach(e => context.Employees.AddOrUpdate(e));
            context.SaveChanges();
        }
    }
}

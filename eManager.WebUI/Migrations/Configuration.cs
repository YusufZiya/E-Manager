namespace eManager.WebUI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using eManager.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.WebUI.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.WebUI.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department { Name = "Engineering" },
                new Department { Name = "Sales" },
                new Department { Name = "Shipping" },
                new Department { Name = "Human Resources" });
        }
    }
}
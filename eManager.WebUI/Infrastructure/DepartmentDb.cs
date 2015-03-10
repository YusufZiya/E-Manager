using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eManager.Domain;

namespace eManager.WebUI.Infrastructure
{
    public class DepartmentDb:DbContext,IDepartmentDataSource
    {
        public DepartmentDb():base("DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public IQueryable<Employee> _Employees
        {
            get
            {
                return Employees;
            }
        }

        public IQueryable<Department> _Departments
        {
            get
            {
                return Departments;
            }

        }
    }
}
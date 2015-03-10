using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eManager.Domain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employess { get; set; }
        IQueryable<Department> Departments { get; set; }
    }
}

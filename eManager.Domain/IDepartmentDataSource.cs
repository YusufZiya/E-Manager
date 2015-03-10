using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eManager.Domain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> _Employees { get; }
        IQueryable<Department> _Departments { get; }
    }
}

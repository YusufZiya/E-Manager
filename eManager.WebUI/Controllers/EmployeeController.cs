using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.WebUI.Models;
using eManager.Domain;

namespace eManager.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int DepartmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = DepartmentId;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _db._Departments.Single(d => d.Id == viewModel.DepartmentId);

                var employee = new Employee();
                employee.Name = viewModel.Name;
                employee.HiredDate = viewModel.HiredDate;

                department.Employees.Add(employee);
                _db.Save();

                return RedirectToAction("Detail", "Departmnet", new { id = viewModel.DepartmentId });
            }

            return View(viewModel);
        }

    }
}

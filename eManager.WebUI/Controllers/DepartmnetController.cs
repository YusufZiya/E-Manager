using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.WebUI.Infrastructure;

namespace eManager.WebUI.Controllers
{
    public class DepartmnetController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public DepartmnetController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Detail(int id)
        {
            var model = _db._Departments.Single(d => d.Id == id);
            return View(model);
        }

    }
}

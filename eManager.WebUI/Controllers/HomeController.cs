using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.WebUI.Infrastructure;

namespace eManager.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IDepartmentDataSource _db;
        
        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDepartment = _db._Departments;

            return View(allDepartment);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

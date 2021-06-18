using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Models;
using University.Models.Database;

namespace University.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Department()
        {
            Database db = new Database();
            var departments = db.Departments.GetAll();
            return View(departments);
        }

        public ActionResult DepartmentCreate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DepartmentCreate(Department d)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Departments.Insert(d);
                return RedirectToAction("Department");
            }
            return View();
        }
    }
}
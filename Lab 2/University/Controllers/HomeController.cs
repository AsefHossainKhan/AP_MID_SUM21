using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Models;
using University.Models.Database;

namespace University.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Admin a = new Admin();
            return View(a);
        }

        [HttpPost]
        public ActionResult Index(Admin a)
        {
            Database db = new Database();
            string dbPassword = db.Admins.Validate(a.Username);
            if (dbPassword == a.Password && dbPassword != null)
            {
                return RedirectToAction("StudentView");
            }

            TempData["ErrorMessage"] = "Incorrect Username/Password";
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StudentCreate()
        {
            Student s = new Student();
            Database db = new Database();
            dynamic comboData = new ExpandoObject();
            comboData.Student = s;
            comboData.Department = db.Departments.GetAll();
            return View(comboData);
        }
        [HttpPost]
        public ActionResult StudentCreate(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("StudentView");
            }
            return View();
        }

        public ActionResult StudentView()
        {
            Database db = new Database();
            var students = db.Students.GetAllWithDeptName();
            return View(students);
        }

        public ActionResult StudentDelete(int id)
        {
            Database db = new Database();
            db.Students.Delete(id);
            return View();
        }

        public ActionResult StudentEdit(int id)
        {

            Database db = new Database();
            var s = db.Students.Get(id);

            return View(s);
        }
        [HttpPost]
        public ActionResult StudentEdit(Student s)
        {
            //update to db
            Database db = new Database();
            db.Students.Update(s);
            return RedirectToAction("StudentView");
        }

        public ActionResult Department()
        {
            return View();
        }
    }
}
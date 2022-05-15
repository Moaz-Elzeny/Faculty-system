using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        FacultyEntities db = new FacultyEntities();
        public ActionResult Index()
        {
            List<Department> list = db.Departments.ToList();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Students(int id)
        {
            List<Student> studintList = db.Students.Where(x => x.Deptid == id).ToList();
            return View(studintList);
        }

        public ActionResult Contact()
        {
            WebsiteDesc obj =  db.WebsiteDescs.FirstOrDefault();

            return View(obj);
        }
    }
}
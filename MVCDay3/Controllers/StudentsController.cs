using MVCDay3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay3.Controllers
{
    public class StudentsController : Controller
    {

        ITIContext context = new ITIContext();

        public ActionResult Index()
        {
            List<Student> st = context.Students.ToList();

            return View(st);
        }
        public ActionResult instractor()
        {
            List<Instractor> st = context.Instractors.ToList();

            return View(st);
        }
        public ActionResult depts()
        {
            List<Department> st = context.Departments.ToList();

            return View(st);
        }

        public ActionResult about()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }
    }
}
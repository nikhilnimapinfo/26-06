using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace Dependencyinjection.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee = null;
        private IStudent _student = null;
        
        public HomeController(IEmployee employee, IStudent student)
        {
            _employee = employee;

            _student = student;
          

        }

        public ActionResult Index()
        {
            int count = _employee.EmployeeTotalReturn();
            bool student = _student.isstudent();
           

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
    }
}
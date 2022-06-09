using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employees")]
        //public ActionResult GetList()
        //{
        //    return View("GetList","_Layout");
        //}
        public ActionResult GetList()
        {
            return View();
        }
        [Route("NewEmployee")]
        //public ActionResult AddEmployee()
        //{
        //    return View("AddEmployee", "_Layout");
        //}
        public ActionResult AddEmployee()
        {
            return View();
        }
    }
}
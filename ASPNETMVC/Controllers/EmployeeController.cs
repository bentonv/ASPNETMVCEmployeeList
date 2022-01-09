using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETMVC.Models;


namespace ASPNETMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        /*public String Index()
        {
            //return View();
            return "Welcome to EmployeeController!";

        }*/

        public ActionResult Index()
        {
            var list = Session["Employees"] as List<EmployeeInfo>;
            return View(list);

            ViewBag.Greeting = "Hello, world!";
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeInfo e)
        {
            var list = Session["Employees"] as List<EmployeeInfo>;
            if(list == null)
            {
                list = new List<EmployeeInfo>();
            }
            list.Add(e);
            Session["Employees"] = list;
            //return View();
            return RedirectToAction("Index");
        }


    }
}
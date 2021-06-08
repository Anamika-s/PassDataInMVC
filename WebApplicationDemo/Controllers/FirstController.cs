using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class FirstController : Controller
    {

       
        public ActionResult Index()
        {
            ViewBag.data = "hello";
            ViewBag.Date = DateTime.Now.ToString();
            return View();
        }

        public ActionResult Method1()
        {
            if(TempData["CompanyName"] !=null)
            ViewBag.CompanyName = TempData["CompanyName"];
            return View();
        }

        public ActionResult Method2()
        {
            ViewBag.name = "Ajay Sood";
            ViewData["address"] = "Delhi";
            return View();
        }


        public string Method3()
        {
            return "Hello";
        }

        public ActionResult Method4()
        {
            return RedirectToAction("Method1");
        }

        public ActionResult Method5()
        {
            TempData["CompanyName"] = "CTS";
            return RedirectToAction("Method1");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Entidades;
using System.Web.Razor;


namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [AllowAnonymous]
        public bool CreateUSer()
        {
            bool succec = false;


            return succec;
        }

    }
}

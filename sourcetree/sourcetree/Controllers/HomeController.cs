﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sourcetree.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "";

            ViewData["Message"] = "Welcome to ASP.NET MVC444!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

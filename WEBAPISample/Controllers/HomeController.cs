﻿using System;
using System.Linq;
using System.Web.Mvc;

namespace WEBAPISample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

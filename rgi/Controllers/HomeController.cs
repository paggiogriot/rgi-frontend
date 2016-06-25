﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Terms() {
            ViewBag.Message = "Your terms page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult MainContent() {
            return PartialView("MainContent");
        }

        [ChildActionOnly]
        public ActionResult SideBar01() {
            return PartialView("SideBar01");
        }

        [ChildActionOnly]
        public ActionResult SideBar02() {
            return PartialView("SideBar02");
        }

    }
}
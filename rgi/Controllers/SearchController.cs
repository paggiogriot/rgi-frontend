﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgi.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index(string q) {
            return View();
        }

        public ActionResult Category(string id) {
            return View();
        }
    }
}
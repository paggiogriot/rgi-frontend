﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgi.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
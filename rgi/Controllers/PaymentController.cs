using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgi.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        public ActionResult Index(string id)
        {
            if (string.IsNullOrEmpty(id)) {
                return View();
            }
            return View(id);
        }
    }
}
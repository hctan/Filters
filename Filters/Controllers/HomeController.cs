using Filters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [CustomAuth(false)]
        public ActionResult Index()
        {
            ViewBag.Message = "This is the Index action on the Home controller";
            return View();
        }
    }
}
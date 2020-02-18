using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChocolateShop.Controllers
{
    public class DisplayListController : Controller
    {
        // GET: DisplayList
        public ActionResult Index()
        {
            return View();
        }
    }
}
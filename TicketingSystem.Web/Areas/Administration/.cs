using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketingSystem.Web.Areas.Administration
{
    public class CategoriesController : Controller
    {
        // GET: Administration/Categories
        public ActionResult Index()
        {
            return View();
        }
    }
}
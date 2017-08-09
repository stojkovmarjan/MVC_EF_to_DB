using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EF_to_DB.Controllers
{
    public class HomeController : Controller
    {
        /*
         * https://www.aspsnippets.com/Articles/ASPNet-MVC-Simple-Entity-Framework-Tutorial-with-example.aspx
         * Database to EF tutorial
         * */
        public ActionResult Index()
        {
            NORTHWNDEntities entities = new NORTHWNDEntities();
            return View(from customer in entities.Customers.Take(10)
                        select customer);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
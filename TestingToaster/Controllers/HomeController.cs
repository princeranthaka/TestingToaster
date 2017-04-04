using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingToaster.Models;

namespace TestingToaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.AddToastMessage("Congratulations", "You have implemented a Government Toast", ToastType.Success);
            return View();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NateBotSecure.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MyViewModel
            {
                CurrentCommand = MvcApplication.CurrentCommand,
                CurrentSpeed = MvcApplication.RobotSpeed
            };
            return View(model);
        }
        public class MyViewModel
        {
            public string CurrentCommand { get; set; }
            public int CurrentSpeed { get; set; }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Bot Controlling Application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
using HelloWorld.Services;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var homeModel = new HomeModel();
            var sayHelloManager = new SayHelloManager();
            homeModel.SayHelloProviders = sayHelloManager.GetSayHelloProviders();

            return View(homeModel);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

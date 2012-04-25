using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
using HelloWorld.Services;
using System.ComponentModel.Composition;

namespace HelloWorld.Controllers
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    public class HomeController : Controller
    {
        SayHelloManager _sayHelloManager;

        [ImportingConstructor]
        public HomeController(SayHelloManager sayHelloManager)
        {
            _sayHelloManager = sayHelloManager;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var homeModel = new HomeModel();
            homeModel.SayHelloProviders = _sayHelloManager.SayHelloProviders;

            return View(homeModel);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

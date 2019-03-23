using TeamAlpha.GoldenOracle.DAL;
using TeamAlpha.GoldenOracle.Models;
using TeamAlpha.GoldenOracle.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace TeamAlpha.GoldenOracle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

// Special thanks to my group members Zachary Hordynski, Sebastian Wurst, and Terri Thorpe for making this project come together.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamAlpha.GoldenOracle.Models;

namespace TeamAlpha.GoldenOracle.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult SaveCreature(string Name)
        {
            var random = new Random();

            HomeController.encounterCreatures.Add(new EncounterCreature { Name = Name, Initiative = random.Next(1,20) });
            return RedirectToAction("Index", "Home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5e_DM_ToolKit_v1.Models;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult SaveCreature(string Name, int Initiative)
        {
            var random = new Random();

            HomeController.encounterCreatures.Add(new EncounterCreature { Name = Name, Initiative = Initiative });
            return RedirectToAction("Index", "Home");
        }
    }
}
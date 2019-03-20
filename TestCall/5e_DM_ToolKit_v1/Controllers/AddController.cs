using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamAlpha.GoldenOracle.Models;
using TeamAlpha.GoldenOracle.Models.ViewModels;

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
        public ActionResult SaveCreature(EncounterCreature encounterCreature)
        {
            var encounterView = new EncounterViewModel();
            EncounterViewModel.encounterCreatures.Add(encounterCreature);

            if (EncounterViewModel.creaturesQueue.Count != 0)
            {
                int i = EncounterViewModel.creaturesQueue.Count;
                while (EncounterViewModel.creaturesQueue.Peek().Initiative > encounterCreature.Initiative && i > 0)
                {
                    EncounterViewModel.creaturesQueue.Enqueue(EncounterViewModel.creaturesQueue.Dequeue());
                    i--;
                }
                for (int j = EncounterViewModel.encounterCreatures.Count - i; j > 0; j--)
                {
                    EncounterViewModel.creaturesQueue.Enqueue(EncounterViewModel.creaturesQueue.Dequeue());
                }
            }

            return RedirectToAction("_EncounterLayout", "Encounter", encounterView);
        }
    }
}
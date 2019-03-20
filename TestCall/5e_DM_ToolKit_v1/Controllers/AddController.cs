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
        public ActionResult SaveCreature(EncounterCreature encounterCreature)
        {

            EncounterController.encounterCreatures.Add(encounterCreature);

            if (EncounterController.creaturesQueue.Count != 0)
            {
                int i = EncounterController.creaturesQueue.Count;
                while (EncounterController.creaturesQueue.Peek().Initiative > encounterCreature.Initiative && i > 0)
                {
                    EncounterController.creaturesQueue.Enqueue(EncounterController.creaturesQueue.Dequeue());
                    i--;
                }
                for (int j = EncounterController.encounterCreatures.Count - i; j > 0; j--)
                {
                    EncounterController.creaturesQueue.Enqueue(EncounterController.creaturesQueue.Dequeue());
                }
            }

            return RedirectToAction("Index", "Encounter");
        }
    }
}
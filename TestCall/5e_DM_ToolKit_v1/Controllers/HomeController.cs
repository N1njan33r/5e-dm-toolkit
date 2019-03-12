using TeamAlpha.GoldenOracle.DAL;
using TeamAlpha.GoldenOracle.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace TeamAlpha.GoldenOracle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Queue<EncounterCreature> creaturesQueue = new Queue<EncounterCreature>();

            // Note: Add feature to add a new creature mid-encounter without messing up current order.
            if (encounterCreatures.Count > 1)
                encounterCreatures.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            foreach (var x in encounterCreatures)
            {
                creaturesQueue.Enqueue(x);
            }

            return View(creaturesQueue);
        }

        public ActionResult NextTurn()
        {
            //creaturesQueue.Enqueue(creaturesQueue.Dequeue());
            return RedirectToAction("Index", "Home");
        }

        public static List<EncounterCreature> encounterCreatures = new List<EncounterCreature>();
    }
}
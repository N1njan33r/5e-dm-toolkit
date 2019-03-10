using _5e_DM_ToolKit_v1.DAL;
using _5e_DM_ToolKit_v1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (encounterCreatures.Count > 1)
            //    encounterCreatures.Sort((x, y) => x.Initiative.CompareTo(y.Initiative));
            List<EncounterCreature> test = TestList();
            if (test.Count > 1)
                test.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            Queue<EncounterCreature> creaturesQueue = new Queue<EncounterCreature>();
            //foreach (var x in encounterCreatures)
            //{
            //    creaturesQueue.Enqueue(x);
            //}
            foreach (var x in test)
            {
                creaturesQueue.Enqueue(x);
            }

            return View(creaturesQueue);
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public List<EncounterCreature> encounterCreatures = new List<EncounterCreature>();

        public List<EncounterCreature> TestList()
        {
            encounterCreatures.Add(new EncounterCreature { Name = "Bulthok", Initiative = 4 });
            encounterCreatures.Add(new EncounterCreature { Name = "Grog", Initiative = 13 });
            encounterCreatures.Add(new EncounterCreature { Name = "Vaxx", Initiative = 24 });
            encounterCreatures.Add(new EncounterCreature { Name = "Percy", Initiative = 8 });
            encounterCreatures.Add(new EncounterCreature { Name = "Pike", Initiative = 11 });
            encounterCreatures.Add(new EncounterCreature { Name = "Taryon", Initiative = 1 });

            return encounterCreatures;
        }
    }
}
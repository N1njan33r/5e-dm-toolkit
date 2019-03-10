using _5e_DM_ToolKit_v1.DAL;
using _5e_DM_ToolKit_v1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class HomeController : Controller
    {
        //private DungeonContext db = new DungeonContext();
        List<EncounterCreature> encounterCreature = new List<EncounterCreature>();

        public ActionResult Index()
        {
            if (encounterCreature == null)
            {
                return HttpNotFound();
            }

            encounterCreature.Add(new EncounterCreature { Name = "Boozy" });
            EncounterCreature creature1 = new EncounterCreature { Name = "Booshy" };

            return View("Index", creature1.Name);
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public List<EncounterCreature> encounterCreatures = new List<EncounterCreature>();
    }
}
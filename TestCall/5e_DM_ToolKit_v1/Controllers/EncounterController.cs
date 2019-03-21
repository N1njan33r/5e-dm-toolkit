using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TeamAlpha.GoldenOracle.DAL;
using TeamAlpha.GoldenOracle.Models;
using TeamAlpha.GoldenOracle.Models.ViewModels;

namespace TeamAlpha.GoldenOracle.Controllers
{
    public class EncounterController : Controller
    {
        private DungeonContext db = new DungeonContext();

        // GET: Encounter
        public ActionResult Index()
        {
            EncounterViewModel encounterView = new EncounterViewModel();

            SetEncounterCreatures(encounterView);

            //encounterView.EncounterCreatures = creaturesQueue;
            //List<EncounterCreature> encounter = encounterCreatures;

            //if (encounter.Count > 1)
            //    encounter.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            //creaturesQueue.Clear();
            //foreach (var x in encounter)
            //{
            //    creaturesQueue.Enqueue(x);
            //}

            return View(encounterView);
        }

        public PartialViewResult EncounterView()
        {
            return PartialView("_EncounterView");
        }

        public async Task<PartialViewResult> MonstersDetail(int id, bool value)
        {
            var encounter = new EncounterViewModel();

            SetEncounterCreatures(encounter);

            if (value == true)
            {

                var client = new HttpClient();
                var urlExtension = $"api/monsters/" + id;

                client.BaseAddress = new Uri("http://dnd5eapi.co/");
                var result = await client.GetAsync(urlExtension);
                var monster = await result.Content.ReadAsAsync<Monsters>();

                encounter.Monsters = monster;

                //return PartialView("_MonstersDetail", encounter);
            }

            else if (value == false)
            {
                Characters character = db.Characters.Find(id);
                encounter.Characters = character;

                //return PartialView("_MonstersDetail", encounter);
            }

            return PartialView("MonstersDetail", encounter);
        }

        //[ChildActionOnly]
        //public ActionResult MonstersDetail(EncounterCreature creature)
        //{
        //    return PartialView("MonstersDetail");
        //}

        public ActionResult NextTurn()
        {
            EncounterViewModel encounter = new EncounterViewModel
            {
                EncounterCreatures = EncounterViewModel.creaturesQueue
            };
            if (encounter.EncounterCreatures.Count > 0)
            {
                encounter.EncounterCreatures.Enqueue(encounter.EncounterCreatures.Dequeue());
                return PartialView("_EncounterLayout", encounter);
            }
            else
            {
                return View("Index");
            }
        }

        public void SetEncounterCreatures(EncounterViewModel encounterView)
        {
            encounterView.EncounterCreatures = EncounterViewModel.creaturesQueue;
            List<EncounterCreature> encounter = EncounterViewModel.encounterCreatures;

            if (encounter.Count > 1)
                encounter.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            EncounterViewModel.creaturesQueue.Clear();
            foreach (var x in encounter)
            {
                EncounterViewModel.creaturesQueue.Enqueue(x);
            }
        }

        public ActionResult _EncounterLayout(EncounterViewModel encounterView)
        {
            SetEncounterCreatures(encounterView);
            encounterView.EncounterCreatures = EncounterViewModel.creaturesQueue;
            return PartialView(encounterView);
        }
    }
}
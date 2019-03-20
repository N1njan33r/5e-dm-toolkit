﻿using TeamAlpha.GoldenOracle.DAL;
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
        private DungeonContext db = new DungeonContext();

        public ActionResult Index()
        {
            EncounterViewModel encounterView = new EncounterViewModel();
            encounterView.EncounterCreatures = creaturesQueue;
            List<EncounterCreature> encounter = encounterCreatures;

            // Note: Add feature to add a new creature mid-encounter without messing up current order.
            if (encounter.Count > 1)
                encounter.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            creaturesQueue.Clear();
            foreach (var x in encounter)
            {
                creaturesQueue.Enqueue(x);
            }

            return View(encounterView);
        }

        //[ChildActionOnly]
        //public ActionResult MonstersDetail(EncounterCreature creature)
        //{
        //    return PartialView("MonstersDetail");
        //}

        //public ActionResult NextTurn()
        //{
        //    if (creaturesQueue.Count > 0)
        //        creaturesQueue.Enqueue(creaturesQueue.Dequeue());

        //    return View("Index", creaturesQueue);
        //}

        public async Task<PartialViewResult> MonstersDetail(int? id, bool? value)
        {
            var encounter = new EncounterViewModel();

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

            return PartialView("_MonstersDetail", encounter);
        }

        public static Queue<EncounterCreature> creaturesQueue = new Queue<EncounterCreature>();
        public static List<EncounterCreature> encounterCreatures = new List<EncounterCreature>();
    }
}
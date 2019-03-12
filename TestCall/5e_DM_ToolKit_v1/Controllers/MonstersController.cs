using TeamAlpha.GoldenOracle.DAL;
using TeamAlpha.GoldenOracle.Models;
using System.Web.Mvc;
using PagedList;
using System;
using System.Linq;
using System.Collections.Generic;

namespace TeamAlpha.GoldenOracle.Controllers
{
    public class MonstersController : Controller
    {
        private DungeonContext db = new DungeonContext();
        // GET: Monster


        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var monsters = from s in db.Monsters
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                monsters = monsters.Where(s => s.Name.Contains(searchString)
                                       || s.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    monsters = monsters.OrderByDescending(s => s.Name);
                    break;

                default:
                    monsters = monsters.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 25;
            int pageNumber = (page ?? 1);
            return View(monsters.ToPagedList(pageNumber, pageSize));
        }

        
        public ActionResult SendMonster(string name)
        {
            Monsters monster = new Monsters() { Name = name }; 

            return RedirectToAction("SaveCreature", "Add", monster);
        }
    }
}
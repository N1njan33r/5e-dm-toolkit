using _5e_DM_ToolKit_v1.DAL;
using _5e_DM_ToolKit_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class CharacterController : Controller
    {
        private DungeonContext db = new DungeonContext();

        // GET: Character
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Characters characters)
        {

            db.Characters.Add(characters);
            db.SaveChanges();

            return View();
        }

    }
}
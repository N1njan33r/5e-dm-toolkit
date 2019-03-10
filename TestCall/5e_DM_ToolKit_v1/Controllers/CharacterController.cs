using _5e_DM_ToolKit_v1.DAL;
using _5e_DM_ToolKit_v1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public ActionResult List()
        {

            return View(db.Characters.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }

    public static class HtmlExtensions
    {
        public static HtmlString EnumDisplayNameFor(this Enum item)
        {
            var type = item.GetType();
            var member = type.GetMember(item.ToString());
            DisplayAttribute displayName = (DisplayAttribute)member[0].GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            if (displayName != null)
            {
                return new HtmlString(displayName.Name);
            }

            return new HtmlString(item.ToString());
        }
    }
}
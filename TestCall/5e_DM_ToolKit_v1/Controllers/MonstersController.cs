using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class MonstersController : Controller
    {
        // GET: Monster
        public ActionResult Index()
        {
            ViewBag.Title = "Monsters";
            return View();
        }
    }
}
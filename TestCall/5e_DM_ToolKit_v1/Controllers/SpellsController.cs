using _5e_DM_ToolKit_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class SpellsController : Controller
    {
        // GET: Spells
        public async Task<ActionResult> Index()
        {
            Spells spells = null;
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://dnd5eapi.co/");

            for (int i = 0; i < 319; i++)
            {
                var result = await client.GetAsync($"api/spells/{i}");
                spells = await result.Content.ReadAsAsync<Spells>();

            }

            return View(spells);

        }
    }
}
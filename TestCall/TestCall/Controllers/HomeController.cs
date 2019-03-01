using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TestCall.Models;

namespace TestCall.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            TestGet testGet = null;
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://dnd5eapi.co/");
            var result = await client.GetAsync("api/spells/1");
            testGet = await result.Content.ReadAsAsync<TestGet>();
            //string data = await result.Content.ReadAsStringAsync();
            //JavaScriptSerializer jSerializer = new JavaScriptSerializer();
            //var testData = jSerializer.Deserialize<List<TestGet>>(data);
            //ViewData["stuff"] = testData;
            return View(testGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

//Response.AppendHeader("Access-Control-Allow-Origin", "*");
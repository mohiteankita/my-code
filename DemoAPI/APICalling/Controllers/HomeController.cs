using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CallingAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44310/api/Demo/");
            var resp = client.GetAsync("https://localhost:44310/api/Demo/");
            var result = resp.Result;
            if(result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsAsync<string>();
                res.Wait();
                string restext = res.Result;
                TempData["APIResp"] = restext;
            }
            return View();
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
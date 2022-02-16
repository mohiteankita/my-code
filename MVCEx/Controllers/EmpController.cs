using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        [HttpGet]
        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string name = collection["TxtName"].ToString();
            Session["name"] = name;
            return View();
        }
    }
}
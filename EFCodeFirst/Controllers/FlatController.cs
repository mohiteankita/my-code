using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproachEF.Models;

namespace CodeFirstApproachEF.Controllers
{
    public class FlatController : Controller
    {
        // GET: Flat
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Flat f)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<FlatContex>());
            FlatContex contex = new FlatContex();
            contex.Flats.Add(f);
            contex.SaveChanges();
            return View();
        }
    }
}
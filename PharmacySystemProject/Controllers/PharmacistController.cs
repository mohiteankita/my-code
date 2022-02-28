using Online_Pharmacy_System_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Pharmacy_System_Project.Controllers
{
    public class PharmacistController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pharmacist pharmacist)
        {
            Online_Pharmacy_SystemEntities6 entity = new Online_Pharmacy_SystemEntities6();
            entity.Pharmacists.Add(pharmacist);
            entity.SaveChanges();
            return RedirectToAction(actionName: "Create", controllerName: "Login");
        }
    }
}
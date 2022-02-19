using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseFirstApproachEntityFramework.Models;

namespace DatabaseFirstApproachEntityFramework.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            return View(ent.DEPARTMENTS);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DEPARTMENT d)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            ent.DEPARTMENTS.Add(d);
            ent.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            DEPARTMENT d = ent.DEPARTMENTS.Find(id);
            return View(d);
        }

        [HttpPost]
        public ActionResult Edit(DEPARTMENT d)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            DEPARTMENT dept_obj = ent.DEPARTMENTS.Find(d.DEPARTMENT_ID);
            dept_obj.DEPARTMENT_NAME = d.DEPARTMENT_NAME;
            dept_obj.LOCATION_ID = d.LOCATION_ID;
            dept_obj.MANAGER_ID = d.MANAGER_ID;
            ent.SaveChanges();
            return View(d);
        }

        public ActionResult Details(int id)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            DEPARTMENT d = ent.DEPARTMENTS.Find(id);
            return View(d);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            DEPARTMENT d = ent.DEPARTMENTS.Find(id);
            return View(d);
        }

        [HttpPost]
        public ActionResult Delete(DEPARTMENT d)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            DEPARTMENT dept_obj = ent.DEPARTMENTS.Find(d.DEPARTMENT_ID);
            ent.DEPARTMENTS.Remove(dept_obj);
            ent.SaveChanges();
            return View();
        }
    }
}
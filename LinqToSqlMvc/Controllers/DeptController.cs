using MVCLinkToSql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinkToSql.Controllers
{
    public class DeptController : Controller
    {
        DeptLinqDataContext context = new DeptLinqDataContext();
        // GET: Dept
        public ActionResult Index()
        {
            return View(context.DEPARTMENTs);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DEPARTMENT d)
        {
            context.DEPARTMENTs.InsertOnSubmit(d);
            context.SubmitChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            DEPARTMENT d = (from data in context.DEPARTMENTs
                            where data.DEPARTMENT_ID == id
                            select data).Single();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(DEPARTMENT d)
        {
            DEPARTMENT dept = (from data in context.DEPARTMENTs
                            where data.DEPARTMENT_ID == d.DEPARTMENT_ID
                            select data).Single();

            dept.DEPARTMENT_NAME = d.DEPARTMENT_NAME;
            dept.LOCATION_ID = d.LOCATION_ID;
            dept.MANAGER_ID = d.MANAGER_ID;
            context.SubmitChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            DEPARTMENT d = (from data in context.DEPARTMENTs
                            where data.DEPARTMENT_ID == id
                            select data).Single();
            return View(d);
        }

        [HttpPost]
        public ActionResult Delete(DEPARTMENT d)
        {
            DEPARTMENT dept = (from data in context.DEPARTMENTs
                            where data.DEPARTMENT_ID == d.DEPARTMENT_ID
                            select data).Single();
            context.DEPARTMENTs.DeleteOnSubmit(dept);
            context.SubmitChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            DEPARTMENT d = (from data in context.DEPARTMENTs
                            where data.DEPARTMENT_ID == id
                            select data).Single();
            return View(d);
        }
    }
}
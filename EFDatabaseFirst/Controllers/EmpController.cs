using DatabaseFirstApproachEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirstApproachEntityFramework.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            HRMSDBEntities entity = new HRMSDBEntities();
            return View(entity.EMPLOYEES);
        }
    }
}
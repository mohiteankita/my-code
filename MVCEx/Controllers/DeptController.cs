using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            DeptBal bal = new DeptBal();
            List<Department> dept_list = bal.GetDeptList();
            TempData["deptlist"] = dept_list;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDalEx1.Models;

namespace MVCDalEx1.Controllers
{
    public class DeptController : Controller
    {
        DepartmentDal dal = new DepartmentDal();
        // GET: Dept
        public ActionResult Index()
        {
            List<Department> deptlist = dal.GetDeptList();
            return View(deptlist);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        /*public ActionResult Insert(FormCollection collection)
        {
            Department dept = new Department();
            dept.deptid = Convert.ToInt32(collection["deptid"]);
            dept.deptname = collection["deptname"].ToString();
            dept.location = collection["location"].ToString();
            dept.country = collection["country"].ToString();
            dal.InsertDepartment(dept);
            return View();
        }*/

        public ActionResult Insert(Department d)
        {
            if(ModelState.IsValid)
            {
                dal.InsertDepartment(d);
                //Session["msg"] = "Data Inserted Successfully";//for display message to user
                //ViewData["msg"] = "Data Inserted Successfully";
                ViewBag.msg = "Data Inserted Successfully";//for alert
                //return RedirectToAction("MessageView");
            }
            return View();
        }

        public ActionResult MessageView()
        {
            return View();
        }

        public ActionResult Update(int deptid)
        {
            Department dept = dal.GetDepartment(deptid);
            return View(deptid);
        }

        [HttpPost]
        public ActionResult Update(Department d)
        {
           dal.UpdateDepartment(d);                   
            return View(d);
        }

        public ActionResult Details(int id)
        {
            Department dept = dal.GetDepartment(id);
            return View(dept);
        }

        public ActionResult Delete(int id)
        {
            Department dept = dal.GetDepartment(id);
            return View(dept);
        }

        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            Department dept = dal.GetDepartment(Convert.ToInt32(collection["deptid"]));
            dal.DeleteDepartment(dept);
            return RedirectToAction("Index");
        }
    }
}
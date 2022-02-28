using MVCDalExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDalExample.Controllers
{
    public class HomeController : Controller
    {
        /*DepartmentDAL dal = new DepartmentDAL();
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
        public ActionResult Insert(FormCollection collection)
        {
            Department dept = new Department();
            dept.department_id = Double.Parse(collection["department_id"]);
            dept.department_name = collection["department_name"].ToString();
            dept.location_id = Double.Parse(collection["location_id"].ToString());
            dept.manager_id = Double.Parse(collection["manager_id"].ToString());

            dal.InsertDepartment(dept);
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Department dept = dal.GetDepartment(id);
            return View(dept);
        }

        [HttpPost]
        public ActionResult Update(Department d)
        {
            dal.UpdateDepartment(d);
            Session["msg"] = "Data Updated Successfully";
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Department d = dal.GetDepartment(id);
            return View(d);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Department d = dal.GetDepartment(id);
            return View(d);
        }

        [HttpPost]
        public ActionResult Delete(Department d)
        {
            Department dept = dal.GetDepartment(Convert.ToInt32(d.department_id));
            dal.DeleteDepartment(dept);
            ViewBag.delmsg = "Data Deleted Successfully";
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
        */

        //DepartmentDAL dal = new DepartmentDAL();
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public JsonResult List()
        //{
        //    return Json(dal.GetDeptList(), JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult Add(Department dept)
        //{
        //    return Json(dal.InsertDepartment(dept), JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult GetbyID(int id)
        //{
        //    var Department = dal.GetDeptList().Find(x => x.department_id.Equals(id));
        //    return Json(Department, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult Update(Department dept)
        //{
        //    return Json(dal.UpdateDepartment(dept), JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult Delete(int id)
        //{
        //    return Json(dal.DeleteDepartment(id), JsonRequestBehavior.AllowGet);
        //}
    }
}
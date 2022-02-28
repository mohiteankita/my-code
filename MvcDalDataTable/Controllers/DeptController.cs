using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDalExample.Models;

namespace MVCDalExample.Controllers
{
    public class DeptController : Controller
    {

             DepartmentDAL dal = new DepartmentDAL();
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
            //Session["msg"] = "Data Inserted Successfully";
            ViewData["msg"] = "Data Inserted Successfully";
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
            return View(d);
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

        public ActionResult MessageView()
        {
            return View();
        }


        public JsonResult List()
        {
            List<Department> deptlist = dal.GetDeptList();
            return Json(deptlist, JsonRequestBehavior.AllowGet);
        }
        public ActionResult IndexPage()
        {
            List<Department> deptlist = dal.GetDeptList();

            return View(deptlist);

        }


        //    [HttpGet]
        //    public ActionResult InsertDept()
        //    {
        //        return View();
        //    }

       
        public JsonResult InsertDept(Department dept)
        {
            int res = 0;
            //Department dept = new Department();
            //dept.department_id = Double.Parse(collection["department_id"]);
            //dept.department_name = collection["department_name"].ToString();
            //dept.location_id = Double.Parse(collection["location_id"].ToString());
            //dept.manager_id = Double.Parse(collection["manager_id"].ToString());
            try
            {
                dal.InsertDepartment(dept);
                res = 1;
            }
            catch(Exception ex)
            {
                res = 0;
                Console.WriteLine(ex.Message);

            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }


    }

}
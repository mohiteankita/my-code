using ClientApiDept.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ClientApiDept.Controllers
{
    public class DepartmentController : Controller
    {
        ServiceRepository repository = new ServiceRepository();
        string url = "https://localhost:44398/api/DeptApi";

        // GET: Department
        public ActionResult Index1()
        {
            return View();
        }

        public JsonResult GetData()
        {
            List<Department> dlist = null;
            try
            {
                HttpResponseMessage response = repository.GetResponse(url);
                response.EnsureSuccessStatusCode();
                dlist = response.Content.ReadAsAsync<List<Department>>().Result;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Json(dlist, JsonRequestBehavior.AllowGet);
        }
    }
}
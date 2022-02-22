using ClientApiDept.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ClientApiDept.Controllers
{
    public class DeptController : Controller
    {
        ServiceRepository repository = new ServiceRepository();
        string url = "https://localhost:44398/api/DeptApi";
        // GET: Dept
        public ActionResult Index()
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
            return View(dlist);
        }

        [HttpGet]
        public ActionResult IndexDept(int id)
        {
            Department d = null;
            try
            {
                HttpResponseMessage response = repository.GetResponse("https://localhost:44398/api/DeptApi?id=" + id);
                response.EnsureSuccessStatusCode();
                d = response.Content.ReadAsAsync<Department>().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(d);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department d)
        {
            HttpResponseMessage response = repository.PostResponse("https://localhost:44398/api/DeptApi", d);
            response.EnsureSuccessStatusCode();
            int no = response.Content.ReadAsAsync<int>().Result;
            if (no > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            Department d = null;
            try
            {
                HttpResponseMessage response = repository.GetResponse("https://localhost:44398/api/DeptApi?id=" + id);
                response.EnsureSuccessStatusCode();
                d = response.Content.ReadAsAsync<Department>().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(d);

        }

        [HttpPost]
        public ActionResult Edit(Department d)
        {
            HttpResponseMessage response = repository.PutResponse("https://localhost:44398/api/DeptApi/UpdateDepartment", d);
            response.EnsureSuccessStatusCode();
            int no = response.Content.ReadAsAsync<int>().Result;
            if (no > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int id)
        {
            Department d = null;
            try
            {
                HttpResponseMessage response = repository.GetResponse("https://localhost:44398/api/DeptApi?id=" + id);
                response.EnsureSuccessStatusCode();
                d = response.Content.ReadAsAsync<Department>().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(d);

        }

        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            int department_id = Convert.ToInt32(collection["deptid"].ToString());
            HttpResponseMessage response = repository.DeleteResponse("https://localhost:44398/api/DeptApi/DeleteDepartment?id=" + department_id);
            response.EnsureSuccessStatusCode();
            int no = response.Content.ReadAsAsync<int>().Result;
            if (no > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
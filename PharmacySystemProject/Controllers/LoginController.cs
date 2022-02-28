using Online_Pharmacy_System_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Pharmacy_System_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            //Online_Pharmacy_SystemEntities5 entity = new Online_Pharmacy_SystemEntities5();
            //Login1 login = new Login1();
            //List<string> rolelist = new List<string>();
            //rolelist.Add("--Select--");
            //rolelist.Add("Customer");
            //rolelist.Add("Pharmacist");

            //SelectList list_of_role = new SelectList(rolelist);
            //login.RoleType = list_of_role;
            //return View(login);

            return View();
        }

        [HttpPost]
        public ActionResult Create(Login1 login)
        {
            Online_Pharmacy_SystemEntities5 entity = new Online_Pharmacy_SystemEntities5();
            entity.Login1.Add(login);
            entity.SaveChanges();

            //string Username = login.Username;
            //string Password = login.Password;

            //string role = entity.LoginRoleType(Username, Password).ToString();

            //if (role == "Customer")
            //{
            //    return RedirectToAction(actionName: "Index", controllerName: "Order");
            //}
            //else if (role == "Pharmacist")
            //{
            //    return RedirectToAction(actionName: "Index", controllerName: "Medicine");
            //}

            if (login.Role == "Customer")
            {
                return RedirectToAction(actionName: "Index", controllerName: "Order");
            }
            else if (login.Role == "Pharmacist")
            {
                return RedirectToAction(actionName: "Index", controllerName: "Medicine");
            }
            return View();
        }
    }
}
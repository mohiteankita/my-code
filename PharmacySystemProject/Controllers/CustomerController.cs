using Online_Pharmacy_System_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Pharmacy_System_Project.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customer
        public ActionResult Index()
        {
                Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
                return View(entity.Customers);
            
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
            entity.Customers.Add(customer);
            entity.SaveChanges();
            return RedirectToAction(actionName: "Create", controllerName: "Login");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
            Customer customer = entity.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
            Customer customer_obj = entity.Customers.Find(customer.Customer_Id);

            customer_obj.First_Name = customer.First_Name;
            customer_obj.Last_Name = customer.Last_Name;
            customer_obj.Email = customer.Email;
            customer_obj.Phone_No = customer.Phone_No;
            customer_obj.Address = customer.Address;

            entity.SaveChanges();
            return View(customer);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
            Customer customer = entity.Customers.Find(id);
            return View(customer);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
            Customer customer = entity.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            Online_Pharmacy_SystemEntities1 entity = new Online_Pharmacy_SystemEntities1();
            Customer customer_obj = entity.Customers.Find(customer.Customer_Id);
            entity.Customers.Remove(customer_obj);
            entity.SaveChanges();
            return View();
        }
    }
   
}
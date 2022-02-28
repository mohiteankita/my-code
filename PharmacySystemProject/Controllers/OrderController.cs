using Online_Pharmacy_System_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Pharmacy_System_Project.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View(new Order());
        }

        [HttpPost]
        public ActionResult Index(Order order)
        {
            int quantity = (int)order.Quantity;
            int amount = (int)order.Amount;
            order.Total_Amount = quantity * amount;

            Session["ordermsg"] = order.Customer_Name;
            return View(order);
        }
       
    }
}
using Online_Pharmacy_System_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Pharmacy_System_Project.Controllers
{
    public class MedicineController : Controller
    {
        // GET: Medicine
        public ActionResult Index()
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            return View(entity.Medicines);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Medicine medicine)
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            entity.Medicines.Add(medicine);
            entity.SaveChanges();
            Session["insertmedi"] = "Medicine Inserted Successfully!!";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            Medicine medicine = entity.Medicines.Find(id);
            return View(medicine);
        }

        [HttpPost]
        public ActionResult Edit(Medicine medicine)
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            Medicine medicine_obj = entity.Medicines.Find(medicine.Medicine_Id);

            medicine_obj.Reference_No = medicine.Reference_No;
            medicine_obj.Medicine_Type = medicine.Medicine_Type;
            medicine_obj.Medicine_Name = medicine.Medicine_Name;
            medicine_obj.Mfg_Date = medicine.Mfg_Date;
            medicine_obj.Exp_Date = medicine.Exp_Date;
            medicine_obj.Medicine_Price = medicine.Medicine_Price;
            entity.SaveChanges();

            Session["editmedi"] = "Medicine Edited Successfully";
            return View(medicine);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            Medicine medicine = entity.Medicines.Find(id);
            return View(medicine);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            Medicine medicine = entity.Medicines.Find(id);
            return View(medicine);
        }

        [HttpPost]
        public ActionResult Delete(Medicine medicine)
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            Medicine medicine_obj = entity.Medicines.Find(medicine.Medicine_Id);
            entity.Medicines.Remove(medicine_obj);
            entity.SaveChanges();
            Session["deletemedi"] = "Medicine Deleted Successfully!!";
            return View();
        }

        public ActionResult ShowMedicines()
        {
            Online_Pharmacy_SystemEntities entity = new Online_Pharmacy_SystemEntities();
            return View(entity.Medicines);
        }
    }
}
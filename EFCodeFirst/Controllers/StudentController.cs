using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproachEF.Models;
namespace CodeFirstApproachEF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Student s)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<StudentContext>());
            StudentContext context = new StudentContext();
            context.Students.Add(s);
            context.SaveChanges();
            return View();
        }
    }
}
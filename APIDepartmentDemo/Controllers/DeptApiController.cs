using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DepartmentAPI.Models;

namespace DepartmentAPI.Controllers
{
    public class DeptApiController : ApiController
    {
        // GET api/<controller>
        DepartmentDal dal = new DepartmentDal();
        public List<Department> Get()
        {
            List<Department> dlist = dal.GetDeptList();
            return dlist;
        }

        // GET api/<controller>/5
        [HttpGet]
        public Department Get(int id)
        {
            Department d = dal.GetDepartment(id);
            return d;
        }

        // POST api/<controller>
        [HttpPost]
        public int Post(Department d)
        {
            try
            {
                dal.InsertDepartment(d);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        // PUT api/<controller>/5
        [HttpPut]
        public int Put(Department d)
        {
            try
            {
                dal.UpdateDepartment(d);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            dal.DeleteDepartment(id);
        }
    }
}

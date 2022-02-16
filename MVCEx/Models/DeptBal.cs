using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class DeptBal
    {
        public List<Department> GetDeptList()
        {
            List<Department> dept_list = new List<Department>();

            dept_list.Add(new Department() { deptid = 111, deptname = "Sales", location = "Pune", country = "India" });
            dept_list.Add(new Department() { deptid = 112, deptname = "Admin", location = "Nagpur", country = "India" });
            dept_list.Add(new Department() { deptid = 113, deptname = "Accounting", location = "Mumbai", country = "India" });
            dept_list.Add(new Department() { deptid = 114, deptname = "Purchase", location = "Mumbai", country = "India" });

            return dept_list;
        }
    }
}
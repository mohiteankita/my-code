using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDalEx1.Models
{
    public class Department
    {
        public int deptid { get; set; }

        public string deptname { get; set; }

        public string location { get; set; }

        public string country { get; set; }
    }
}
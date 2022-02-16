using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class Department
    {
        public int deptid { get; set; }

        public string deptname { get; set; }

        public string location { get; set; }

        public string country { get; set; }
    }
}
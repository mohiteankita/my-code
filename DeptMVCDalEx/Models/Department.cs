using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDalExample.Models
{
    public class Department
    {
        public double department_id { get; set; }

        public string department_name { get; set; }

        public double manager_id { get; set; }

        public double location_id { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApiDept.Models
{
    public class Department
    {
        [Required(ErrorMessage = "Please Enter Department ID It Cannot Be Left Blank")]
        public int deptid { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        public string deptname { get; set; }

        [Required(ErrorMessage = "Please Enter Location")]
        public string location { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        public string country { get; set; }
    }
}
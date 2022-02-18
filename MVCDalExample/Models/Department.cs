using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDalEx1.Models
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
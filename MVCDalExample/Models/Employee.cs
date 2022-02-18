using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDalEx1.Models
{
    public class Employee
    {
        [Required(ErrorMessage="Emter Employee Id")]
        public int empid { get; set; }

        [Required(ErrorMessage = "Enter Employee Name")]
        [StringLength(10, ErrorMessage ="Name Should be 10 characters")]
        public int empname { get; set; }

        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string emailaddress { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Pharmacy_System_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [Required(ErrorMessage="Customer Id Cannot Be Left Blank")]
        public int Customer_Id { get; set; }

        [Required(ErrorMessage="Please Enter First Name")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile Number")]
        public string Phone_No { get; set; }

        [Required(ErrorMessage = "Address Should Be Required")]
        public string Address { get; set; }
    }
}
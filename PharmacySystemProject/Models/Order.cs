//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Pharmacy_System_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Order
    {
        [Required(ErrorMessage="Please Enter Order Id")]
        public int Order_Id { get; set; }

        [Required(ErrorMessage = "Please Your Enter Name")]
        public string Customer_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Medicine Name")]
        public string Medicine_Name { get; set; }

        [Required(ErrorMessage = "Amount Should Be Required")]
        public Nullable<int> Amount { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity Of Medicine")]
        public Nullable<int> Quantity { get; set; }

        public Nullable<int> Total_Amount { get; set; }
    }
}

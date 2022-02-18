using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDalEx1.Models
{
    public class UserClass
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="Please Enter User Name")]


        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_Application_Management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            if(TxtName.Text == "")
            {
                Response.Write("Please Enter Your Name");
            }
            else
            {
                //Session["name"] = TxtName.Text;
                Application["name"] = TxtName.Text;
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_Application_Management
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(Session["name"].ToString() != "")
            {
                string name = Session["name"].ToString();
                Response.Write("Welcome " + name);
            }
            */
            if (Application["name"].ToString() != "")
            {
                string name = Application["name"].ToString();
                Response.Write("Welcome " + name);
            }
        }
    }
}
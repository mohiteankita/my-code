using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GlobalDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int appcode = Convert.ToInt32((Application["appcounter"]).ToString());
            appcode++;
            Application["appcounter"] = appcode;

            int sesscode = Convert.ToInt32((Session["sesscounter"]).ToString());
            sesscode++;
           
            Response.Write("Application Code " + appcode);
            Response.Write("Session Code " + sesscode);
        }
    }
}
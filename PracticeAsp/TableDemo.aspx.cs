using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeAsp
{
    public partial class TableDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                dropdownstate.Items.Add("Maharashtra");
                dropdownstate.Items.Add("Goa");
                dropdownstate.Items.Add("Gujrat");
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Hello " + TxtName.Text);
            Response.Write("Hidden Field is " + Hidden1.Value);
        }

        protected void dropdownstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Selected value is " + dropdownstate.SelectedValue + "');" + "</script>");
        }
    }
}
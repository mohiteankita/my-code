using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeAsp
{
    public partial class LifeCycleAspDotNet : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("PreInit Called <br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Init Called <br/>");
            Button b = new Button();
            b.Text = "Click Me";
            b.Click += B_Click;         
            Page.Form.Controls.Add(b);

        }

        private void B_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('button added dynamically')</script>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("PreLoad Called <br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Load Called <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("PreRender Called <br/>");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Render Called <br/>");
        }

    }
}
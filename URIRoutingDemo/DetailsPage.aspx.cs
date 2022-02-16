using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace URIRoutingDemo
{
    public partial class DetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["id"].ToString() != null)
            {
                string rid = Page.RouteData.Values["id"].ToString();
                SqlConnection connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=HRMSDB; trusted_connection=true");
                SqlCommand cmd = new SqlCommand("select * from Article_Table where id='" + rid + "'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                string title = dataset.Tables[0].Rows[0]["Title"].ToString();
                string desc = dataset.Tables[0].Rows[0]["Description"].ToString();
                Label1.Text = title;
                Label2.Text = desc;
                Page.DataBind();
            }
        }
    }
}
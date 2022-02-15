using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAspDotNet
{
    public partial class GridView1st : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*SqlDataSource ds = new SqlDataSource();
            ds.ConnectionString = WebConfigurationManager.ConnectionStrings["cons"].ConnectionString;
            ds.SelectCommand = "select * from departments";
            ds.ProviderName = "System.Data.SqlClient";
            GridView1.DataSource = ds;
            GridView1.DataBind();*/

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["cons"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Employees");
            DataTable table = ds.Tables[0];
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}
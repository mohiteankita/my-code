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
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=HRMSDB; trusted_connection=true");
            SqlCommand cmd = new SqlCommand("select * from Article_Table", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            GridView1.DataSource = dataset.Tables[0];
            GridView1.DataBind();
        }

        protected string getTitle(object str)
        {
            return str.ToString().Replace(' ', '-');
        }
    }
}
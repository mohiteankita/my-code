using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace LoginFormDemo
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegi_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandText = "InsertRegistrationDetails";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                string uname = TxtUname.Text;
                string pass = TxtPass.Text;

                cmd.Parameters.AddWithValue("uname", uname);
                cmd.Parameters.AddWithValue("pass", pass);

                int no = cmd.ExecuteNonQuery();

            } 
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
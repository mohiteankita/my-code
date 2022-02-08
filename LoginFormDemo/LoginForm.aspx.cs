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
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            /*string uname = TxtUname.Text;
            string password = TxtPass.Text;
            if(uname == "Admin" && password == "Admin@123")
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Invalid Username & Password");
            }
            */

            /*string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from AspNew where username='" + TxtUname.Text + "' and password='" + TxtPass.Text + "'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                cmd.ExecuteNonQuery();
                if(datatable.Rows[0][0].ToString()=="1")
                {
                    Response.Write("<script>alert('successful in login')</script>");
                }
                else
                {
                    Response.Write("<script>alert('error in login')</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            */

            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetUserPass";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("uname", TxtUname.Text);
                cmd.Parameters.AddWithValue("pass", TxtPass.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Response.Write("<script>alert('successful in login')</script>");
                }
                else
                {
                    Response.Write("<script>alert('error in login')</script>");
                }
                
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
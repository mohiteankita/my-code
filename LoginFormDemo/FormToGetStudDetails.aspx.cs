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
    public partial class FormToGetStudDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            string fname = TxtFname.Text;
            string lname = TxtLname.Text;
            string uname = TxtUname.Text;
            string dob = CalDob.SelectedDate.ToString();
            string gender = null;
            if (RdoMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string education = DropDownEdn.SelectedValue;
            string hobbies = null;
            if (ChkRead.Checked)
            {
                hobbies = "Reading";
            }
            if (ChkDance.Checked)
            {
                hobbies = "Dancing";
            }
            if (ChkSing.Checked)
            {
                hobbies = "Singing";
            }
            string pass = TxtPass.Text;

            string data = fname + ", " + lname + ", " + uname + ", " + dob + ", " + gender + ", " + education + ", " + hobbies;
            Response.Write("<script>alert('" + data + "')</script>");

            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "InsertStudDetailsFromRegiForm";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);
                cmd.Parameters.AddWithValue("uname", uname);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.Parameters.AddWithValue("dob", dob);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("qualification", education);
                cmd.Parameters.AddWithValue("hobbies", hobbies);

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
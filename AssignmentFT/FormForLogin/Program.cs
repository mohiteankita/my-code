using System;
using System.Data;
using System.Data.SqlClient;

namespace FormForLogin
{
    class Program
    {
        public void LoginForm()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS;database=AspDotNet;trusted_connection=true");

                Console.WriteLine("Enter username: ");
                string uname = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string pass = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("insert into AspNew(username, password) values('"+uname+"','"+pass+"')", connection);              
                cmd.CommandType = CommandType.Text;
                
                SqlCommand cmd1 = new SqlCommand("select count(*) from AspNew where username='"+uname+"'", connection);
                cmd1.CommandType = CommandType.Text;

                connection.Open();
                int count = (int)cmd1.ExecuteScalar();
                if (count > 0)
                {
                    Console.WriteLine("Username Already Exists");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record Saved in Database");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.LoginForm();
        }
    }
}

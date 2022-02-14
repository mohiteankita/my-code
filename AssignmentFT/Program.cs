using System;
using System.Data;
using System.Data.SqlClient;

namespace UpdateDuplicateElseInsert
{
    class Program
    {
        public void UpdateInsertStudentDetails()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=DatabaseFT; trusted_connection=true");
                connection.Open();

                SqlCommand cmd = new SqlCommand("UpdateInsertStudData", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("Enter Student Id: ");
                int student_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter First Name: ");
                string first_name = Console.ReadLine();

                Console.WriteLine("Enter Last Name: ");
                string last_name = Console.ReadLine();

                Console.WriteLine("Enter Address: ");
                string address = Console.ReadLine();

                cmd.Parameters.AddWithValue("student_id", student_id);
                cmd.Parameters.AddWithValue("first_name", first_name);
                cmd.Parameters.AddWithValue("last_name", last_name);
                cmd.Parameters.AddWithValue("address", address);

                cmd.ExecuteNonQuery();
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank You!! Visit Again");
                connection.Close();
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.UpdateInsertStudentDetails();
        }
    }
}

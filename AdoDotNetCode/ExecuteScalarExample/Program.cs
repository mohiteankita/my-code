using System;
using System.Data;
using System.Data.SqlClient;

namespace ExecuteScalarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS;database=HRMSDB;trusted_connection=true");
                connection.Open();

                SqlCommand cmd = new SqlCommand("select sum(salary) as total_salary from employees", connection);
                cmd.CommandType = CommandType.Text;

                decimal total_salary = (decimal)cmd.ExecuteScalar();
                Console.WriteLine("Total salary is " + total_salary);
                connection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

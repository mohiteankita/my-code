using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetConnectedArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=LAPTOP-81HIQF3R\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
                connection.Open();

                //Get department using id 
                //Create command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetDepartmentUsingId";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("Enter department id: ");
                int deptid = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.AddWithValue("deptid", deptid);
                int no = cmd.ExecuteNonQuery();
               
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);
                }
               

                //Get department data
                /*SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetDepartmentData";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);
                }*/

                //Insert department data 
                /*SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "InsertDepartment";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("Enter Department Id: ");
                int dept_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Department Name: ");
                string dept_name = Console.ReadLine();

                Console.WriteLine("Enter Manager Id: ");
                int manager_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Location Id: ");
                int location_id = Convert.ToInt32(Console.ReadLine());

                cmd.Parameters.AddWithValue("deptid", dept_id);
                cmd.Parameters.AddWithValue("deptname", dept_name);
                cmd.Parameters.AddWithValue("manager_id", manager_id);
                cmd.Parameters.AddWithValue("location_id", location_id);

                int no = cmd.ExecuteNonQuery();
                Console.WriteLine("Department details inserted successfully");
                */

                //update department data
                /*SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UpdateDepartments";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("Enter Department Id: ");
                int dept_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Department Name: ");
                string dept_name = Console.ReadLine();

                Console.WriteLine("Enter Manager Id: ");
                int manager_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Location Id: ");
                int location_id = Convert.ToInt32(Console.ReadLine());

                cmd.Parameters.AddWithValue("deptid", dept_id);
                cmd.Parameters.AddWithValue("deptname", dept_name);
                cmd.Parameters.AddWithValue("manager_id", manager_id);
                cmd.Parameters.AddWithValue("location_id", location_id);

                int no = cmd.ExecuteNonQuery();
                Console.WriteLine("Department details updated successfully");
                */

                //delete department detail
                /*SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DeleteDepartment";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("Enter Department Id: ");
                int dept_id = Convert.ToInt32(Console.ReadLine());

                cmd.Parameters.AddWithValue("deptid", dept_id);

                int no = cmd.ExecuteNonQuery();
                Console.WriteLine("Department detail deleted successfully");
                */
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

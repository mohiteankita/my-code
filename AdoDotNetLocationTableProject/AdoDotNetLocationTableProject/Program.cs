using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetLocationTableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=HRMSDB; trusted_connection=true";

                //Creare command
                SqlCommand cmd = new SqlCommand();
                char continueornot = 'Y';
                SqlDataReader reader;
                int no;
                while (continueornot == 'Y')
                {
                    Console.WriteLine("Enter Correct Choice From Following: ");
                    Console.WriteLine("1.Select Location");
                    Console.WriteLine("2.Select Location By Id");
                    Console.WriteLine("3.Insert Location");
                    Console.WriteLine("4.Update Location");
                    Console.WriteLine("5.Delete Location");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            connection.Open();
                            cmd.CommandText = "Get_Location_Details";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            reader = cmd.ExecuteReader();
                            Console.WriteLine("Locations Details.......");
                            while(reader.Read())
                            {
                                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4] + "\t" + reader[4] + "\t");
                            }
                            Console.WriteLine("___________________________________________________________________________________________________________");
                            connection.Close();
                            break;

                        case 2:
                            connection.Open();
                            cmd.CommandText = "Get_Location_By_Id";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            Console.WriteLine("Enter Location Id: ");
                            int location_id = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("location_id", location_id);
                            no = cmd.ExecuteNonQuery();

                            reader = cmd.ExecuteReader();
                            Console.WriteLine("Locations Detail.......");
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4] + "\t" + reader[4] + "\t");
                            }
                            Console.WriteLine("___________________________________________________________________________________________________________");
                            connection.Close();
                            break;

                        case 3:
                            connection.Open();
                            cmd.CommandText = "Insert_Location_Details";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();

                            Console.WriteLine("Enter Location Id: ");
                            int location_id0 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Street Address: ");
                            string street_address = Console.ReadLine();

                            Console.WriteLine("Enter Postal Code: ");
                            string postal_code = Console.ReadLine();

                            Console.WriteLine("Enter City: ");
                            string city = Console.ReadLine();

                            Console.WriteLine("Enter State Province: ");
                            string state_province = Console.ReadLine();

                            Console.WriteLine("Enter Country Id: ");
                            string country_id = Console.ReadLine();

                            cmd.Parameters.AddWithValue("location_id", location_id0);
                            cmd.Parameters.AddWithValue("street_address", street_address);
                            cmd.Parameters.AddWithValue("postal_code", postal_code);
                            cmd.Parameters.AddWithValue("city", city);
                            cmd.Parameters.AddWithValue("state_province", state_province);
                            cmd.Parameters.AddWithValue("country_id", country_id);

                            no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Location Details Inserted Successfully!!");
                            Console.WriteLine("___________________________________________________________________________________________________________");
                            connection.Close();
                            break;

                        case 4:
                            connection.Open();
                            cmd.CommandText = "Update_Location_Details";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();

                            Console.WriteLine("Enter Location Id: ");
                            int location_id1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Street Address: ");
                            string street_address2 = Console.ReadLine();

                            Console.WriteLine("Enter Postal Code: ");
                            string postal_code3 = Console.ReadLine();

                            Console.WriteLine("Enter City: ");
                            string city4 = Console.ReadLine();

                            Console.WriteLine("Enter State Province: ");
                            string state_province5 = Console.ReadLine();

                            Console.WriteLine("Enter Country Id: ");
                            string country_id6 = Console.ReadLine();

                            cmd.Parameters.AddWithValue("location_id", location_id1);
                            cmd.Parameters.AddWithValue("street_address", street_address2);
                            cmd.Parameters.AddWithValue("postal_code", postal_code3);
                            cmd.Parameters.AddWithValue("city", city4);
                            cmd.Parameters.AddWithValue("state_province", state_province5);
                            cmd.Parameters.AddWithValue("country_id", country_id6);

                            no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Location Details Updated Successfully!!");
                            Console.WriteLine("___________________________________________________________________________________________________________");
                            connection.Close();
                            break;

                        case 5:
                            connection.Open();
                            cmd.CommandText = "Delete_Location_Details";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();

                            Console.WriteLine("Enter Location Id: ");
                            int location_id2 = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("location_id", location_id2);
                          
                            no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Location Details Deleted Successfully!!");
                            Console.WriteLine("___________________________________________________________________________________________________________");
                            connection.Close();
                            break;
                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;
                    }
                    Console.WriteLine("Do You Want To Continue Again Y/N");
                    continueornot = Convert.ToChar(Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

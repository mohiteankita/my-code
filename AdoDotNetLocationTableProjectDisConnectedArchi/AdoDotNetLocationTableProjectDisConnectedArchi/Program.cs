using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetLocationTableProjectDisConnectedArchi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char continueOrNot;
                int choice;
                do
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=HRMSDB;trusted_connection=true";

                    SqlCommand cmd = new SqlCommand("Get_Location_Details", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset, "LOCATIONS");

                    DataTable table = dataset.Tables["LOCATIONS"];

                    Console.WriteLine("1.Select All Location Details");
                    Console.WriteLine("2.Select Location Using Location Id");
                    Console.WriteLine("3.Insert Location");
                    Console.WriteLine("4.Update Location");
                    Console.WriteLine("5.Delete Location");

                    Console.WriteLine("Enter Your Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1 :
                            Console.WriteLine("Location Details.....");
                            foreach(DataRow row in table.Rows)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3] + "\t" + row[4] + "\t" + row[5]);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter Location Id To Be Selected");
                            int location_id = Convert.ToInt32(Console.ReadLine());
                            DataRow[] selrow = table.Select("location_id=" + location_id);
                            Console.WriteLine("Location Id " + location_id + " Details: ");
                            foreach(DataRow row in selrow)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3] + "\t" + row[4] + "\t" + row[5]);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter Location Id: ");
                            int location_id3 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Street Address: ");
                            string street_address3 = Console.ReadLine();

                            Console.WriteLine("Enter Postal Code: ");
                            string postal_code3 = Console.ReadLine();

                            Console.WriteLine("Enter City: ");
                            string city3 = Console.ReadLine();

                            Console.WriteLine("Enter State Province: ");
                            string state_province3 = Console.ReadLine();

                            Console.WriteLine("Enter Country Id: ");
                            string country_id3 = Console.ReadLine();

                            DataRow newrow = table.NewRow();

                            newrow["location_id"] = location_id3;
                            newrow["street_address"] = street_address3;
                            newrow["postal_code"] = postal_code3;
                            newrow["city"] = city3;
                            newrow["state_province"] = state_province3;
                            newrow["country_id"] = country_id3;

                            table.Rows.Add(newrow);
                            adapter.Update(dataset.Tables[0]);
                            Console.WriteLine("Data Inserted Successfully");
                            break;

                        case 4:
                            Console.WriteLine("Enter Location Id: ");
                            int location_id4 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Street Address: ");
                            string street_address4 = Console.ReadLine();

                            Console.WriteLine("Enter Postal Code: ");
                            string postal_code4 = Console.ReadLine();

                            Console.WriteLine("Enter City: ");
                            string city4 = Console.ReadLine();

                            Console.WriteLine("Enter State Province: ");
                            string state_province4 = Console.ReadLine();

                            Console.WriteLine("Enter Country Id: ");
                            string country_id4 = Console.ReadLine();

                            DataRow[] updater = table.Select("location_id=" + location_id4);

                            DataRow updaterow = updater[0];

                            updaterow["location_id"] = location_id4;
                            updaterow["street_address"] = street_address4;
                            updaterow["postal_code"] = postal_code4;
                            updaterow["city"] = city4;
                            updaterow["state_province"] = state_province4;
                            updaterow["country_id"] = country_id4;

                            adapter.Update(dataset.Tables[0]);
                            Console.WriteLine("Data Updated Successfully");
                            break;

                        case 5:
                            Console.WriteLine("Enter Location Id To Be Deleted");
                            int location_id5 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] delrow = table.Select("location_id=" + location_id5);
                            DataRow deleterow = delrow[0];
                            deleterow.Delete();
                            adapter.Update(dataset, "locations");
                            Console.WriteLine("Location Deleted Successfully");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice, Please Enter Valid Choice!!");
                            break;
                    }

                    Console.WriteLine("Enter Y To Continue:");
                    continueOrNot = Convert.ToChar(Console.ReadLine());
                }
                while (continueOrNot == 'Y');
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

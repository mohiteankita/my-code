using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetDisConnectedArchitecture

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char continueOrNor;
                int choice;
                do
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=LAPTOP-81HIQF3R\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";

                    SqlCommand cmd = new SqlCommand("GetDepartmentData", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataSet dataset = new DataSet();

                    adapter.Fill(dataset, "DEPARTMENTS");
                    DataTable table = dataset.Tables["DEPARTMENTS"];

                    Console.WriteLine("1.Select All Departments");
                    Console.WriteLine("2.Select Department Using Department Id");
                    Console.WriteLine("3.Insert Department");
                    Console.WriteLine("4.Update Department");
                    Console.WriteLine("5.Delete Department");

                    Console.WriteLine("Enter Your Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("Department Information");
                            foreach (DataRow row in table.Rows)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter department id to be selected");
                            int dept_id2 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] selrow = table.Select("department_id=" + dept_id2);
                            foreach(DataRow row in selrow)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter Department Id: ");
                            int dept_id3 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Department Name: ");
                            string dept_name3 = Console.ReadLine();

                            Console.WriteLine("Enter Manager Id: ");
                            int manager_id3 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Location Id: ");
                            int location_id3 = Convert.ToInt32(Console.ReadLine());

                            DataRow newrow = table.NewRow();
                            newrow["department_id"] = dept_id3;
                            newrow["department_name"] = dept_name3;
                            newrow["manager_id"] = manager_id3;
                            newrow["location_id"] = location_id3;

                            table.Rows.Add(newrow);
                            adapter.Update(dataset.Tables[0]);
                            Console.WriteLine("Data Inserted Successfully!!");
                            break;

                        case 4:
                            Console.WriteLine("Enter Department Id: ");
                            int dept_id4 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Department Name: ");
                            string dept_name4 = Console.ReadLine();

                            Console.WriteLine("Enter Manager Id: ");
                            int manager_id4 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Location Id: ");
                            int location_id4 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] updater = table.Select("department_id=" + dept_id4);
                            DataRow updaterow = updater[0];
                            updaterow["department_id"] = dept_id4;
                            updaterow["department_name"] = dept_name4;
                            updaterow["manager_id"] = manager_id4;
                            updaterow["location_id"] = location_id4;

                            adapter.Update(dataset.Tables[0]);
                            Console.WriteLine("Data Updated Successfully!!");
                            break;

                        case 5:
                            Console.WriteLine("Enter department id to be deleted");
                            int dept_id5 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] delrow = table.Select("department_id=" + dept_id5);
                            DataRow deleterow = delrow[0];
                            deleterow.Delete();
                            adapter.Update(dataset, "Departments");
                            Console.WriteLine("Department Deleted Successfully");
                            break;

                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;
                    }
                    Console.WriteLine("Enter Y to Continue");
                    continueOrNor = Convert.ToChar(Console.ReadLine());
                }
                while (continueOrNor == 'Y');
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

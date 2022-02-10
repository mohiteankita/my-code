using System;
using System.Data;
using System.Data.SqlClient;

namespace BookDisconnectedArchi
{
    class Program
    {
        public void DisconnectedArchi()
        {
            try
            {
                char conti;
                SqlConnection connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=MYDATABASE; trusted_connection = true");
                SqlCommand cmd = new SqlCommand("GetBookDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "Book");
                DataTable table = dataset.Tables["Book"];

                do
                {
                    Console.WriteLine("1.Display All Book Details");
                    Console.WriteLine("2.Insert Book Details");
                    Console.WriteLine("3.Update Book Details");
                    Console.WriteLine("4.Delete Book Details");
                    Console.WriteLine("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("Book Details: ");
                            foreach(DataRow row in table.Rows)
                            {
                                Console.WriteLine(row["bookid"] + "\t" + row["book_name"] + "\t" + row["author_name"] + "\t" + row["price"]);
                            }
                            Console.WriteLine("_______________________________________________________________");
                            break;
                            
                        case 2:
                            Console.WriteLine("Enter Book Id: ");
                            int bookid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book Name: ");
                            string book_name = Console.ReadLine();
                            Console.WriteLine("Enter Author Name: ");
                            string author_name = Console.ReadLine();
                            Console.WriteLine("Enter Book Price: ");
                            double price = double.Parse(Console.ReadLine());

                            DataRow newrow = table.NewRow();

                            newrow["bookid"] = bookid;
                            newrow["book_name"] = book_name;
                            newrow["author_name"] = author_name;
                            newrow["price"] = price;

                            table.Rows.Add(newrow);
                            adapter.Update(dataset, "Book");
                            Console.WriteLine("Data Inserted Successfully");
                            Console.WriteLine("_______________________________________________________________");
                            break;

                        case 3:
                            Console.WriteLine("Enter Book Id: ");
                            int bookid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book Name: ");
                            string book_name1 = Console.ReadLine();
                            Console.WriteLine("Enter Author Name: ");
                            string author_name1 = Console.ReadLine();
                            Console.WriteLine("Enter Book Price: ");
                            double price1 = double.Parse(Console.ReadLine());

                            DataRow[] updater = table.Select("bookid=" + bookid1);
                            DataRow updaterow = updater[0];

                            updaterow["bookid"] = bookid1;
                            updaterow["book_name"] = book_name1;
                            updaterow["author_name"] = author_name1;
                            updaterow["price"] = price1;

                            adapter.Update(dataset, "Book");
                            Console.WriteLine("Data Updated Successfully");
                            Console.WriteLine("_______________________________________________________________");
                            break;

                        case 4:
                            Console.WriteLine("Enter Book Id: ");
                            int bookid2 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] delrow = table.Select("bookid=" + bookid2);
                            DataRow deleterow = delrow[0];
                            deleterow.Delete();
                            adapter.Update(dataset, "Book");
                            Console.WriteLine("Data Deleted Successfully");
                            Console.WriteLine("_______________________________________________________________");
                            break;

                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;
                    }

                    Console.WriteLine("Do You Want To Continue Y/N: ");
                    conti = Convert.ToChar(Console.ReadLine());
                }
                while (conti == 'Y');

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank You!! Visit Again.");
            }
        }

        static void Main(string[] args)
        {
            new Program().DisconnectedArchi();
        }
    }
}

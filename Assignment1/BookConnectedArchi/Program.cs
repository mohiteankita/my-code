using System;
using System.Data;
using System.Data.SqlClient;

namespace BookConnectedArchi
{
    class Program
    {
        public void ConnectedArchi()
        {
            try
            {
                int bookid;
                string book_name, author_name;
                double price;
                char conti;
                SqlConnection connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=MYDATABASE; trusted_connection = true");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
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
                            connection.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "GetBookDetails";
                            cmd.Connection = connection;
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);
                            }
                            Console.WriteLine("___________________________________________________________________");
                            connection.Close();
                            break;

                        case 2:
                            Console.WriteLine("Enter Book Id: ");
                            bookid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book Name: ");
                            book_name = Console.ReadLine();
                            Console.WriteLine("Enter Author Name: ");
                            author_name = Console.ReadLine();
                            Console.WriteLine("Enter Book Price: ");
                            price = double.Parse(Console.ReadLine());
                            connection.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "InsertBookDetails";
                            cmd.Connection = connection;

                            cmd.Parameters.AddWithValue("bookid", bookid);
                            cmd.Parameters.AddWithValue("book_name", book_name);
                            cmd.Parameters.AddWithValue("author_name", author_name);
                            cmd.Parameters.AddWithValue("price", price);

                            int no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Data Inserted Successfully");
                            Console.WriteLine("____________________________________________________________________");
                            connection.Close();
                            break;

                        case 3:
                            Console.WriteLine("Enter Book Id: ");
                            bookid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book Name: ");
                            book_name = Console.ReadLine();
                            Console.WriteLine("Enter Author Name: ");
                            author_name = Console.ReadLine();
                            Console.WriteLine("Enter Book Price: ");
                            price = double.Parse(Console.ReadLine());
                            connection.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "UpdateBookDetails";
                            cmd.Connection = connection;

                            cmd.Parameters.AddWithValue("bookid", bookid);
                            cmd.Parameters.AddWithValue("book_name", book_name);
                            cmd.Parameters.AddWithValue("author_name", author_name);
                            cmd.Parameters.AddWithValue("price", price);

                            int no1 = cmd.ExecuteNonQuery();
                            Console.WriteLine("Data Updated Successfully");
                            Console.WriteLine("____________________________________________________________________");
                            connection.Close();
                            break;

                        case 4:
                            Console.WriteLine("Enter Book Id: ");
                            bookid = Convert.ToInt32(Console.ReadLine());
                            
                            connection.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "DeleteBookDetails";
                            cmd.Connection = connection;

                            cmd.Parameters.AddWithValue("bookid", bookid);
                           
                            int no2 = cmd.ExecuteNonQuery();
                            Console.WriteLine("Data Deleted Successfully");
                            Console.WriteLine("____________________________________________________________________");
                            connection.Close();
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
            Program p = new Program();
            p.ConnectedArchi();
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace TransactionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Server=LAPTOP-81HIQF3R\\SQLEXPRESS;database=HRMSDB;trusted_connection=true");
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into departments values(8000, 'HR', 200, 1700)", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("insert into departments values(8001, 'HR', 202, 7650)", connection);
                cmd1.CommandType = CommandType.Text;
                cmd1.Transaction = transaction;
                cmd1.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Transaction Committed");
            }
            catch(Exception e)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction is Rolled Back");
            }
        }
    }
}

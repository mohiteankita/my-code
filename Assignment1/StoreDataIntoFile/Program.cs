using System;
using System.IO;

namespace StoreDataIntoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream filestream = new FileStream("MyData.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(filestream);

            Console.WriteLine("Enter data to write into file");
            string fileinfo = Console.ReadLine();
            writer.WriteLine(fileinfo);
            writer.Flush();

            Console.WriteLine("Data Stored into File Successfully");
        }
    }
}

using System;
using System.IO;

namespace StreamReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("FirstFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("Enter data to write into file");
            //string str = Console.ReadLine();
            //writer.WriteLine(str);
            //writer.Flush();
            //Console.WriteLine("Data written successfully");

            StreamReader reader = new StreamReader(fs);
            //Console.WriteLine(reader.ReadLine());
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}

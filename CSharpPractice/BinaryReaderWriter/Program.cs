using System;
using System.IO;

namespace BinaryReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("BinaryData.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            /*BinaryWriter writer = new BinaryWriter(fs);
            Console.WriteLine("Enter employee id: ");
            int empid = Convert.ToInt32(Console.ReadLine());
            writer.Write(empid);
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            writer.Write(name);
            writer.Flush();
            Console.WriteLine("Data written to a file");*/

            BinaryReader reader = new BinaryReader(fs);
            Console.WriteLine("Employee Id= " + reader.ReadInt32());
            Console.WriteLine("Name= " + reader.ReadString());
        }
    }
}

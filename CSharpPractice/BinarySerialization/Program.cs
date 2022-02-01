using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
{
    [Serializable]

    public class Student
    {
        public int rollno;
        public string name;

        public Student() { }

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        public override string ToString()
        {
            return "Roll number= " + rollno + ", Name= " + name;

        }
    }
    class Program
     {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Student01.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            /*Student s = new Student(101, "Payal");
            formatter.Serialize(fs, s);

            Console.WriteLine("Data serialized in binary format");
            Console.ReadLine();*/

            Student obj = (Student) formatter.Deserialize(fs);
            Console.WriteLine(obj);

        }
    }
}

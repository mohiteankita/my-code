using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [Serializable]
    public class Student
    {
        [XmlElement]
        public int rollno;
        [XmlElement]
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
            FileStream fs = new FileStream("Student01.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student s = new Student(101, "Payal");
            xs.Serialize(fs, s);

            Console.WriteLine("Data serialized in xml format");
            fs.Close();

            /*Student obj = (Student)xs.Deserialize(fs);
            Console.WriteLine(obj);*/

        }
    }
}

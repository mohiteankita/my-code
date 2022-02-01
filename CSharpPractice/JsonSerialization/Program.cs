using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonSerialization
{
    [Serializable]
    class Student
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

            FileStream fs = new FileStream("Student11.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            JsonSerializer jsonSerializer = new JsonSerializer();
            /*Student s = new Student(121, "Maya");
            StreamWriter sw = new StreamWriter(fs);
            JsonWriter jsonWriter = new JsonTextWriter(sw);
            jsonSerializer.Serialize(jsonWriter, s);

            jsonWriter.Close();
            sw.Close();*/

            JObject obj = null;
            StreamReader sr = new StreamReader(fs);
            JsonReader jsonReader = new JsonTextReader(sr);
            obj = jsonSerializer.Deserialize(jsonReader) as JObject;
            Console.WriteLine(obj);
            jsonReader.Close();
            sr.Close();
        }
    }
}

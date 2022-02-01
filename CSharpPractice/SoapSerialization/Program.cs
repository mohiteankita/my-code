using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace SoapSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Student01.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
        }
    }
}

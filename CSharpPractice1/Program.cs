using System;

namespace CSharpPractice1
{
    class Program
    {
       [AttributeUsage(AttributeTargets.Class)]
        class NotInUse : System.Attribute
        {
            public bool IsUsed
            {
                get;
                set;
            }
        }
        [NotInUse(IsUsed = false)]
        class Demo
        {

        }
        static void Main(string[] args)
        {
            Type t = typeof(Demo);
            foreach(Attribute a in t.GetCustomAttributes(false))
            {
                NotInUse na = (NotInUse)a;
                if(na.IsUsed == true)
                {
                    Console.WriteLine("Class cannot be used");
                }
                else
                {
                    Console.WriteLine("Class is used");
                }
            }
        }
    }
}

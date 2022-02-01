using System;

namespace CustomAttribute
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class)]
        class BugFixingAttribute : System.Attribute
        {
            public string BugCode
            {
                get;
                set;
            }
            public string DeveloperName
            {
                get;
                set;
            }
            public string FixedDate
            {
                get;
                set;
            }
        }

        [BugFixing(BugCode = "111", DeveloperName = "Allen", FixedDate = "01/02/2022")]
        class Demo
        {

        }
        static void Main(string[] args)
        {
            /*BugFixingAttribute obj = new BugFixingAttribute();
            obj.BugCode = "Hello";
            Console.WriteLine(obj.BugCode);*/

            Type t = typeof(Demo);
            foreach (Attribute a in t.GetCustomAttributes(false))
            {
                BugFixingAttribute ba = (BugFixingAttribute)a;
                Console.WriteLine(ba.BugCode + "-" + ba.DeveloperName + "-" + ba.FixedDate);
            }
        }
    }
}

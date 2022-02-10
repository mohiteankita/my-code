using System;
using MathLibraryDemo;
using System.Reflection;

namespace MainMethodClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to find square and cube: ");
            int no = Convert.ToInt32(Console.ReadLine());

            //By Reflection
            Type t = typeof(MathLibraryDemo.MathLibrary);
            MethodInfo[] methodinfo = t.GetMethods();
            foreach(MethodInfo method in methodinfo)
            {
                object[] parameter = new object[1];
                parameter[0] = no;

                if(method.Name=="Square" || method.Name=="Cube")
                {
                    object o = Activator.CreateInstance(t);
                    object result = method.Invoke(o, parameter);
                    Console.WriteLine(method.Name + " of " + no + "= " + result);
                }
            }
        }
    }
}

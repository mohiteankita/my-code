using System;
using System.Reflection;
using MathLibrary;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MathLibrary.MathClass);
            MethodInfo[] minfo = t.GetMethods();
          
            foreach(MethodInfo mi in minfo)
            {
                Console.WriteLine(mi.Name + " " + mi.ReturnType);
                Console.WriteLine("___________Parameter Info____________________");
                ParameterInfo[] pinfo = mi.GetParameters();
                foreach (ParameterInfo pi in pinfo)
                {
                    Console.WriteLine(pi.Name + "-" + pi.ParameterType + "-" + pi.DefaultValue + "-" + pi.IsIn);
                    
                }
                Console.WriteLine("__________________________________________________________________");

                object[] para = new object[2];
                para[0] = 10;
                para[1] = 5;
                if(mi.Name.ToLower()=="add" || mi.Name.ToLower()=="subtract" || mi.Name.ToLower()=="multiply" || mi.Name.ToLower()=="divide")
                {
                    Console.WriteLine("Invokin Method");
                    object o = Activator.CreateInstance(t);
                    object res = mi.Invoke(o, para);
                    Console.WriteLine("Result is " + res);                  
                }
                Console.WriteLine("**********************************************");
            }
        }
    }
}

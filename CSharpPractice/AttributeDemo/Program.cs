using System;

namespace AttributeDemo
{ 
    class Program
    {
        //[Obsolete("This method is no longer in use")]
        //[Obsolete("This method is no longer in use", true)]
        [Obsolete("This method is no longer in use", error:true)]
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Method1();
        }
    }
}

using System;

namespace UserDefinedGenericCollection
{
    class MathClass<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }

    class Employee
    {
        int empno;
        string ename, designation;

        public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }

        public override string ToString()
        {
            return "Employee Id= " + empno + ", Name= " + ename + ", Designation= " + designation;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathClass<int> obj = new MathClass<int>();
            int x = 100, y = 200;
            Console.WriteLine("Values before swapping x={0} y={1}", x, y);
            obj.Swap(ref x, ref y);
            Console.WriteLine("Values after swapping x={0} y={1}", x, y);

            MathClass<string> obj1 = new MathClass<string>();
            string a = "Hello", b = "World";
            Console.WriteLine("Values before swapping a={0} b={1}", a, b);
            obj1.Swap(ref a, ref b);
            Console.WriteLine("Values after swapping a={0} b={1}", a, b);

            MathClass<Employee> empobj = new MathClass<Employee>();
            Employee e1 = new Employee(1, "jay", "Manager");
            Employee e2 = new Employee(2, "Raj", "Accountant");

            empobj.Swap(ref e1, ref e2);
            Console.WriteLine(e1 + "\n" + e2);
        }
    }
}

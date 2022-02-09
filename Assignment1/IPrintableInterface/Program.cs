using System;

namespace IPrintableInterface
{
    interface IPrintable
    {
        void Print();
    }

    class Employee : IPrintable
    {
        int empid;
        string empname;

        public Employee(int empid, string empname)
        {
            this.empid = empid;
            this.empname = empname;
        }

        public void Print()
        {
            Console.WriteLine("Employee id= " + empid + ", Employee name= " + empname);
        }
    }

    class Student : IPrintable
    {
        int studid;
        string studname;

        public Student(int studid, string studname)
        {
            this.studid = studid;
            this.studname = studname;
        }

        public void Print()
        {
            Console.WriteLine("Student id= " + studid + ", Student name= " + studname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee id: ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name: ");
            string empname = Console.ReadLine();
            
            IPrintable obj = new Employee(empid, empname);
            obj.Print();
            Console.WriteLine("_______________________________________________________");

            Console.WriteLine("Enter student id: ");
            int studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name: ");
            string studname = Console.ReadLine();
            IPrintable obj1 = new Student(studid, studname);
            obj1.Print();
        }
    }
}

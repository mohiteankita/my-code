using System;
using System.Collections.Generic;
using GenericCollectionDemo;
namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List_Collection lobj = new List_Collection();
            List<int> list = lobj.AcceptList();
            Console.WriteLine("List Elements: ");
            foreach(int elt in list)
            {
                Console.WriteLine(elt);
            }

            Console.WriteLine("_____________________________________________________________________________________");

            //Generic Stack
            Stack_Generic obj = new Stack_Generic();
            Stack<string> stk = obj.AcceptStack();

            Console.WriteLine("Stack Elements: ");
            foreach(string elt in stk)
            {
                Console.WriteLine(elt);
            }

            Console.WriteLine("_____________________________________________________________________________________");

            //Student Type List
            /*List<Student> slist = new List<Student>()
            {
                new Student(121, "Ajay", "Msc Maths"),
                new Student(321, "Divya", "BSC Maths"),
                new Student(543, "Allen", "MBA")
            };

            foreach(Student s in slist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("_____________________________________________________________________________________");
            */

            //Dictionary
            Dictionary_Collection o = new Dictionary_Collection();
            Dictionary<int, string> dict = o.AcceptDictionary();
            Console.WriteLine("Dictionary Values= ");
            foreach(KeyValuePair<int, string> d in dict)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            Console.WriteLine("_____________________________________________________________________________________");

            //Employee List
            List<Employee> elist = new List<Employee>()
            {
                new Employee(1, "Raj", "Manager"),
                new Employee(2, "Pratik", "Accountant"),
                new Employee(3, "Ajay", "Sales Manager"),
                new Employee(4, "Sten", "Administrator")
            };
            Console.WriteLine("Employee Details: ");
            foreach(Employee e in elist)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("_____________________________________________________________________________________");

            //Queue
            Queue_Generic qobj = new Queue_Generic();
            Queue<int> q = qobj.AccepetQueue();
            foreach (int e in q)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("_____________________________________________________________________________________");

            //Sorted List
            SortedListCollection sobj = new SortedListCollection();
            SortedList<int, string> list1 = sobj.AcceptSortedList();
            foreach(KeyValuePair<int, string> elt in list1)
            {
                Console.WriteLine(elt.Key + " " + elt.Value);
            }
        }
    }
}

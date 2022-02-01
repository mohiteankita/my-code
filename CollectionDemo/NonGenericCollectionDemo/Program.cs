using System;
using System.Collections;

namespace NonGenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            CollectionArrayList obj = new CollectionArrayList();
            ArrayList alist = obj.AcceptArrayList();
            Console.WriteLine("ArrayList Elements Are: ");
            foreach(Object o in alist)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(alist.Capacity);
            Console.WriteLine(alist[3]);

            Console.WriteLine("__________________________________________________________________________________________");

            //Stack
            NonGeneric_Stack obj1 = new NonGeneric_Stack();
            Stack stk = obj1.AcceptStack();
            Console.WriteLine("Stack Elements Are: ");

            stk.Pop();
            stk.Pop();
            foreach (Object o in stk)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("__________________________________________________________________________________________");

            //Queue
            NonGeneric_Queue obj2 = new NonGeneric_Queue();
            Queue q = obj2.AccepetQueue();
            Console.WriteLine("Queue Elements Are: ");

            q.Dequeue();
            q.Dequeue();
            foreach (Object o in q)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("__________________________________________________________________________________________");

            //Hashtable
            Collection_HashTable obj3 = new Collection_HashTable();
            Hashtable ht = obj3.AcceptHashtable();
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            string val = (string)ht[1.2];
            Console.WriteLine("Value= " + val);
            Console.WriteLine("__________________________________________________________________________________________");

            //SortedList
            SortedListColl sobj = new SortedListColl();
            SortedList slist = sobj.AcceptSortedList();
            foreach(DictionaryEntry elt in slist)
            {
                Console.WriteLine(elt.Key + " " + elt.Value);
            }
        }
}
}

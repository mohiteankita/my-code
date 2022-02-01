using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{ 
    //Generic Collection
    class Stack_Generic
    {
        public Stack<string> AcceptStack()
        {
            Stack<string> stk = new Stack<string>();

            stk.Push("Ajay");
            stk.Push("Gauri");
            stk.Push("Dev");
            stk.Push("Maya");

            return stk;
        }
    }
}

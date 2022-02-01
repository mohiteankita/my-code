using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollectionDemo
{
    class NonGeneric_Stack
    {
        public Stack AcceptStack()
        {
            Stack stk = new Stack();

            stk.Push(34);
            stk.Push(null);
            stk.Push(null);
            stk.Push(56.5f);
            stk.Push(false);
            stk.Push(12);

            return stk;
        }
    }
}

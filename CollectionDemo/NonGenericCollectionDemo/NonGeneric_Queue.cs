using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollectionDemo
{
    class NonGeneric_Queue
    {
        public Queue AccepetQueue()
        {
            Queue q = new Queue();

            q.Enqueue('S');
            q.Enqueue(90.0);
            q.Enqueue(null);
            q.Enqueue(null);
            q.Enqueue("Hi");
            q.Enqueue(87);

            return q;
        }
    }
}

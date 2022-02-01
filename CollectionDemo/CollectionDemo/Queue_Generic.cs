using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Queue_Generic
    {
        public Queue<int> AccepetQueue()
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(10);
            q.Enqueue(4);
            q.Enqueue(89);
            q.Enqueue(8);

            return q;
        }
    }
}

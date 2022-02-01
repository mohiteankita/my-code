using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class SortedListCollection
    {
        public SortedList<int, string> AcceptSortedList()
        {
            SortedList<int, string> slist = new SortedList<int, string>();

            slist.Add(1, "Jain");
            slist.Add(9, "Ketan");
            slist.Add(3, "Priyesh");
            slist.Add(29, "Meena");

            return slist;
        }

        
    }
}

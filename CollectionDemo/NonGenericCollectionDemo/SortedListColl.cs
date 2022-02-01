using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionDemo
{
    class SortedListColl
    {
        public SortedList AcceptSortedList()
        {
            SortedList slist = new SortedList();

            slist.Add(1, "Jain");
            slist.Add(9, "Ketan");
            slist.Add(3, "Pritam");
            slist.Add(29, "Meena");

            return slist;
        }

    }
}

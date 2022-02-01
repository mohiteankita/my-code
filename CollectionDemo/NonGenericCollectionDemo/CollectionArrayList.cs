using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionDemo
{
    class CollectionArrayList
    {
        public ArrayList AcceptArrayList()
        {
            ArrayList alist = new ArrayList();

            alist.Add(34.4f);
            alist.Add(78);
            alist.Add("Hello");
            alist.Add(true);
            alist.Add('A');
            alist.Add(null);
            alist.Add(null);
            alist.Add('A');
            alist.Add(null);
            alist.Insert(2, 29.9);

            return alist;
        }
    }
}

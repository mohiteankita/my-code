using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionDemo
{
    class Collection_HashTable
    {
        public Hashtable AcceptHashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Ajay");
            ht.Add(1.2, "Allen");
            ht.Add(3, "Sten");
            ht.Add("Two", "Payal");

            return ht;
        }
    }
}

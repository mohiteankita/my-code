using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Dictionary_Collection
    {
       public Dictionary<int, string> AcceptDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Ajay");
            dict.Add(2, "Maya");
            dict.Add(5, "Ketan");
            dict.Add(9, "Allen");

            return dict;
        }

       
    }
}

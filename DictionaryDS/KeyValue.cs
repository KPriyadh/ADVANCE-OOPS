using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDS
{
    public class KeyValue<TKey,TValue>
    {
        public TKey Key{get;set;}
        public TValue Value{get;set;}
        
    }
}
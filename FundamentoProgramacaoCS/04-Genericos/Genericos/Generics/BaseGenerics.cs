using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.ServerSentEvents;
using System.Threading.Tasks;

namespace Genericos.Generics
{
    public class BaseGenerics<T>
    {
        private readonly T _item;

        public BaseGenerics(T item)
            => _item = item;

        public T getItem()
        =>  _item;
        
    }
}
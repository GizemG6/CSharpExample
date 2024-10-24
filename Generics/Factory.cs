using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
}

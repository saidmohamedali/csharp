using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class A { public A() { } }

        struct C {  }

        class D<T> where T : new()
        {
            D<A> c1 = new D<A>();  
            D<C> c3 = new D<C>();  
        }
    }
}

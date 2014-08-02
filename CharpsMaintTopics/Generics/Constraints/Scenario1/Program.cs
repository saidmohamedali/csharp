using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class CustomFactory<T>
        {
            public T CreateItem()
            {
                return new T();
            }
        }
    }
}

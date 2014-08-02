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
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(10);
            ints.Add(42);
            List<object> objects = new List<object>();

            // doesnt compile ints is not a IEnumerable<object>
            AddRange<int, object>(ints, objects);
            Console.Read();

        }

        public static void AddRange<S, D>(List<S> source, List<D> destination)
        where S : D
        {
            foreach (S sourceElement in source)
            {
                destination.Add(sourceElement);
            }
        }
    }
}

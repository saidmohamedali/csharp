using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2
{
    class Instrument {
        public override string ToString()
        {
            return "I am simple Instrument";
        }
    }
    class Index:Instrument {
        public override string ToString()
        {
            return "I am an Index";
        }
    }
    class IndexOption : Index {
        public override string ToString()
        {
            return "I am an option over Index";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Index l_index = new Index();
            Instrument l_instrument = l_index;

            Console.WriteLine(l_instrument);

            IndexOption l_indexOption = new IndexOption();
            l_instrument = l_indexOption;
            Console.WriteLine(l_instrument);

            Instrument[] array = new IndexOption[10];
            array[0] = new Index();
            array[1] = new Instrument();
            Console.WriteLine(array);
            Console.Read();
        }

    }
}

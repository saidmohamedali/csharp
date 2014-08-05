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

            Instrument[] l_instruments = new Instrument[3];
            l_instruments[0] = new Index();
            l_instruments[1] = new Instrument();
            l_instruments[2] = new IndexOption();
            for (int l_i = 0; l_i < l_instruments.Length; ++l_i)
                Console.WriteLine(string.Format("array[{0}]={1}:", l_i, l_instruments[l_i]));

            Instrument[] l_instruments2 = new IndexOption[3];
            l_instruments2[0] = new Index(); //Runtime Exception
            l_instruments2[1] = new Instrument();//Runtime Exception
            l_instruments2[2] = new IndexOption();
            for (int l_i = 0; l_i < l_instruments2.Length; ++l_i)
                Console.WriteLine(string.Format("array[{0}]={1}:", l_i, l_instruments2[l_i]));
            Console.Read();
        }

    }
}

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
            int ten = 10;
            int i2 = 2147483647 + ten;
           

            Console.WriteLine(i2 == 2147483657);

            // Checked expression.
            Console.WriteLine(checked(2147483647 + ten));

            // Checked block. 
            checked
            {
                int i3 = 2147483647 + ten;
                Console.WriteLine(i3);
            }
            Console.Read();
        }
    }
}

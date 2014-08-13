using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] objectArray = new int[] { 1, 2, 4 };
            Array myArray = (Array)objectArray;
            
         
            System.Console.WriteLine(myArray.GetType() == typeof(Array));
            Console.WriteLine(myArray.GetType().BaseType == typeof(Array));
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

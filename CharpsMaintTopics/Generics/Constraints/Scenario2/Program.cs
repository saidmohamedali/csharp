using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2
{
    class Program
    {
        
        public static void PrintAreEqual<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s == t);
        }
        static void Main()
        {
            string s1 = "target";
            System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
            string s2 = sb.ToString();
            PrintAreEqual<string>(s1, s2);
            Console.Read();
        }
    }
}

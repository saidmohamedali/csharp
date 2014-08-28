using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1._3
{
    public enum ESperatorType { JSON, CSV }
    public class Seprators
    {

        private static ICollection<char> jsonSepartors = new[] { '\"', '[', ']', '{', '}', ':' }.ToList().AsReadOnly();
        private static ICollection<char> csvSperators = new[]  { ',', ';' }.ToList().AsReadOnly();
        public static ICollection<char> GetSeperators(ESperatorType p_speratorType)
        {
            if (ESperatorType.JSON == p_speratorType)
                return (jsonSepartors);
            else if (ESperatorType.CSV == p_speratorType)
                return (csvSperators);
            else
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char c in Seprators.GetSeperators(ESperatorType.JSON))
            {
                Console.Write(c);
            }
            Seprators.GetSeperators(ESperatorType.JSON).Add('A');
            Console.WriteLine();
            Console.WriteLine("First element of jsonSepartors will now be 'A'");
            foreach (char c in Seprators.GetSeperators(ESperatorType.JSON))
            {
                Console.Write(c);
            }
            Console.Read();
        }
    }
}

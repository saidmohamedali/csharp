﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3
{
    public class Instrument
    {
        public double Price { get; set; }
        public override string ToString()
        {
            return "I am simple Instrument";
        }
    }
    public class Index : Instrument
    {
        public override string ToString()
        {
            return "I am an Index";
        }
    }
    public class IndexOption : Index
    {
        public double Premium { get; set; }
        public override string ToString()
        {
            return "I am an option over Index";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
          
            Action<Instrument> l_PrintNameAction = x => Console.WriteLine("Instrument Type is : {0}", x.ToString());
            Action<Instrument> l_PrintPriceAction = x => Console.WriteLine("Instrument Price: {0}", x.Price);
            Action<IndexOption> l_PrintPremiumAction = x => Console.WriteLine("Extra Info: {0}", x.Premium);
            Delegate.Combine(l_PrintNameAction, l_PrintPriceAction, l_PrintPremiumAction).
                DynamicInvoke((new IndexOption { Price = 12, Premium = 2 }));
            

            Console.Read();
        }
    }
}

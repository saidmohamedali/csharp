﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Generic<T>
        {
            public T Field;
            public T AddSub()
            {
                T i = Field + 1;
            }
        }
    }
}

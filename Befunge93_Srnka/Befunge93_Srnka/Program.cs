﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Befunge93_Srnka
{
    class Program
    {
        static void Main(string[] args)
        {
            Befunge s = new Befunge("testcaseone.bf");
            s.CalcBefunge();
            Console.ReadLine();
        }
    }
}

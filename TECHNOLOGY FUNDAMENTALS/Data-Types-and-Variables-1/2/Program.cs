﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse (Console.ReadLine());
            double result = r * r * Math.PI;
            Console.WriteLine( "{0:f12}",result);
        }
    }
}

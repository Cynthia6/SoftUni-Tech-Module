using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double c = area(a, b);
            Console.WriteLine(c);
        }
            public static double area (double a, double b)
        {
            return  a * b / 2;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            double num =
double.Parse(Console.ReadLine());


            double pow = 
 double.Parse(Console.ReadLine());

            Console.WriteLine(Power(num,pow));
        }
            public static double Power (double a, double b)
        {
            double result = 1d;
            for (int i = 0; i < b; i++)
            {

                result *= a;
            }
                return result;
            
        }
        
    }
}

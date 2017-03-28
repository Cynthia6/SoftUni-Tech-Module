using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a method that calculates and returns the value of a number raised to a given power
namespace _06.Math_Power
{
    class MathPower
    {
        public static double RaiseToPower(double a, double b)
        {
            //double result = 1;
            //for (int i = 1; i <= b; i++)
            //{
            //    result = result * a;
            //}
            double result = Math.Pow(a, b);
            return result;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(a, b));

        }
    }
}
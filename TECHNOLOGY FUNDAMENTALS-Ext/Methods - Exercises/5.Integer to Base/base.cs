using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method IntegerToBase(number, toBase) that receives a number and a base as parameters and returns the number,
// converted to that number base. After that, print the result on the console.
//The number will always be in base 10 and the base parameter will always be between 2 and 10.

namespace _5.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numbase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number,numbase));

        }
        public static string IntegerToBase(int number, int numbase)
        {

            string result = "";
            while (number > 0)
            {
                var remainder = number % numbase;//2
                result = remainder + result;//2
                number = number / numbase;//1
            }

            return result;
        }
    }
}

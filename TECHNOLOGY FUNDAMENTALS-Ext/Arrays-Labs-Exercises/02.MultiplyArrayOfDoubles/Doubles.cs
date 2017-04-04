using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to read an array of doubles, a double p, multiply each element by p and print the resulting array.

namespace _02.MultiplyArrayOfDoubles
{
    class Doubles
    {
        public static void Main()
        {
            var stringNums = Console.ReadLine().Split();
            double[] doubleArr = new double[stringNums.Length];
            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] = double.Parse(stringNums[i]);
            }
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] *= p;
            }

            for (int i = 0; i < doubleArr.Length; i++)
            {
                Console.Write(doubleArr[i] + " " );
            }
        }
    }
}

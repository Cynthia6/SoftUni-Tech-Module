using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

//Calculate and print n! (n factorial) for very big integer n (e.g. 1000).
namespace _03.Big_Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
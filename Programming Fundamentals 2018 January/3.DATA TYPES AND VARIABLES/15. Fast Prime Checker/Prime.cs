using System;
//You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed
//&quot;{number} -&gt; {True or False}&quot;. The code however, is not very well written.Your job is to modify it in a way that is
//easy to read and understand.

namespace _15.Fast_Prime_Checker
{
    class Prime
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int nums = 2; nums <= Math.Sqrt(i); nums++)
                {
                    if (i % nums == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}

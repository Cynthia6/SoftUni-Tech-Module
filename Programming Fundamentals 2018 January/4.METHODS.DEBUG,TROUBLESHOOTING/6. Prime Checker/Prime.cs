using System;
//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.

namespace _6.Prime_Checker
{
    class Prime
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("{0}", IsPrime(n));
        }

        private static bool IsPrime(long number)
        {
            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

    }
}
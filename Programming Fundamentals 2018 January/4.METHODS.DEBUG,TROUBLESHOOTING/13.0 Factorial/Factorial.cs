using System;

//Write a program that calculates and prints the n! for any n in the range [1…1000].

namespace _13._0_Factorial
{
    class Factorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);

        }
    }
}
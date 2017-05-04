using System;
//Create a method that prints the sign of an integer number n.
namespace _02.SignofIntegerNumber
{
    public class Number
    {
        public static void Main()
        {
            int n =int.Parse(Console.ReadLine());

            PrintSign(n);

        }
        public static void PrintSign(int n)
        {
            if (n < 0) Console.WriteLine($"The number {n} is negative.");
            else if(n == 0) Console.WriteLine($"The number {n} is zero.");
            else if (n > 0) Console.WriteLine($"The number {n} is positive.");
        }
    }
}

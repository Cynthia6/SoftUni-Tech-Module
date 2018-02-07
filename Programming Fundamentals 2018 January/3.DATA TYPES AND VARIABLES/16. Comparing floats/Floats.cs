using System;
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that
//we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point
//arithmetic.Therefore, we assume two numbers are equal if they are more closely to each other than some fixed
//constant eps.You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.

namespace _16.Comparing_floats
{
    class Floats
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double precision = 0.000001d;

            double diff = Math.Abs(number1 - number2);
            Console.WriteLine(diff < precision);    // diff < required precision => equal numbers
        }
    }
}
 
using System;

namespace _04.Float_or_Integer
{
    //Write a program that checks whether a number is a real number or an integer number. 
    //If the number is an integer, just print the number. If the number is a real number, print the closest integer to it.
    public class FloatOrInt
    {
        public static void Main()
        {

            var a = 
double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(a,0));


        }
    }
}

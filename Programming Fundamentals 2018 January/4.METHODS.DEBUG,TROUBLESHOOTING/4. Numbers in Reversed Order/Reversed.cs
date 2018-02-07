using System;
using System.Linq;
//Write a method that prints the digits of a given decimal number in a reversed order.


namespace _4.Numbers_in_Reversed_Order
{
    class Reversed
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
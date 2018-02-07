using System;
//Write a program to ask the user for 3 letters and print them in reversed order.

namespace _9.Reversed_chars
{
    class Reversed
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            Console.Write(third + second + first);
            Console.WriteLine();
        }
    }
}

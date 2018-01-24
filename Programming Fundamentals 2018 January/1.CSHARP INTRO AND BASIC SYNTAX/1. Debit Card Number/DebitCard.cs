using System;
//Write a program, which receives 4 integers on the console and prints them in 4-digit debit card format. See the
//examples below for the appropriate formatting.

namespace _1.Debit_Card_Number
{
    class DebitCard
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numOne:D4} {numTwo:D4} {numThree:D4} {numFour:D4}");
        }
    }
}

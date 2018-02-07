using System;

//Create a program to convert a decimal number to hexadecimal and binary number and print it.

namespace _14.Integer_to_Hex_and_Binary
{
    class HexAndBin
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 16).ToUpper());  // to Hex
            Console.WriteLine(Convert.ToString(number, 2));             // to Bin
        }
    }
    
}

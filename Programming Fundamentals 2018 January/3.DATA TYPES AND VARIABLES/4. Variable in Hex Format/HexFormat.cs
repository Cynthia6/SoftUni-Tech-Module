using System;
//Write a program that reads a number in hexadecimal format(0x##) convert it to decimal format and prints it.

namespace _4.Variable_in_Hex_Format
{
    class HexFormat
    {
        static void Main()
        {
            string s1 = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(s1, 16));
        }
    }
}

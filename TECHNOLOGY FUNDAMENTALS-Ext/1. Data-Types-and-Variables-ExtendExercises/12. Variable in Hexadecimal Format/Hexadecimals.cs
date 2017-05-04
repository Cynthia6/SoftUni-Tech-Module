using System;

namespace _12.Variable_in_Hexadecimal_Format
{
    // Write a program that reads a number in hexadecimal format(0x##) convert it to decimal format and prints it.
    public class Hexadecimals
    {
        public static void Main()
        {
            string hexadecimal = Console.ReadLine();
            int decimalValue = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(decimalValue);
        }
    }
}

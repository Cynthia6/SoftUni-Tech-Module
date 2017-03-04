using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Variable_in_Hexadecimal_Format
{
   // Write a program that reads a number in hexadecimal format(0x##) convert it to decimal format and prints it.
    class Hexadecimals
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int decimalValue = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(decimalValue);
        }
    }
}

using System;

namespace _01.Practice_Integer_Numbers
{
    //1.Create a new C# project and create a program that assigns integer values to variables. 
    //Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). 
    //Finally, you need to print all variables to the console.
    public class PracticeInts
    {
        public static void Main()
        {
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            int num6 = -1141583228;
            long num7 = -1223372036854775808;

            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}\n{num5}\n{num6}\n{num7}");

        }
    }
}

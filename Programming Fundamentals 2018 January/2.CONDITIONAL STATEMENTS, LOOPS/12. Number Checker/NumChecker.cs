using System;
//Write a program, which reads an input from the console and prints &quot;It is a number.&quot; if it’s a number. If it is not write
//&quot;Invalid input!&quot;

namespace _12.Number_Checker
{
    class NumChecker
    {
        static void Main()
        {
            try 
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input!");
            }
        }
    }
}

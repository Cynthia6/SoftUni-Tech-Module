using System;
//Write a program, which can receive any type of input, but upon receiving anything other than an integer – stops
//the execution of the program and prints how many numbers were read.

namespace _9.Count_the_Integers
{
    class Integers
    {
        static void Main()
        {
            int count = 0;
            try
            {
                while (true)
                {
                    int nums = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine($"{count}");
            }
        }
    }
}

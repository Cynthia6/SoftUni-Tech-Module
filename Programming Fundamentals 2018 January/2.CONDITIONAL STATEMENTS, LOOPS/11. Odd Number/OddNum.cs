using System;
//Take as an input an odd number and print the absolute value of it. If the number is even, print &quot;Please write an
//odd number.&quot; and continue reading numbers.
namespace _11.Odd_Number
{
    class OddNum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            while (num %2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(num)}");

        }
    }
}

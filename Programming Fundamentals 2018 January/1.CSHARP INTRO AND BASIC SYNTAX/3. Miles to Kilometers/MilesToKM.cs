using System;
//Write a program, which converts miles to kilometers. Format the output to the 2 nd decimal place.
//Note: 1 mile == 1.60934 kilometers

namespace _3.Miles_to_Kilometers
{
    class MilesToKM
    {
        static void Main()
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal result = miles * 1.60934m;
            Console.WriteLine($"{result:F2}");
        }
    }
}

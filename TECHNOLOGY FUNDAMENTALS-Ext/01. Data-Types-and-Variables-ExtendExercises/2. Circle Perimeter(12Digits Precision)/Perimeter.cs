﻿using System;

namespace _2.Circle_Perimeter_12Digits_Precision_
{
    //Write program to enter a radius r (real number) and print the perimeter of a circle with exactly 12 digits after the decimal point.
    // Use data type of enough precision to hold the results.
    public class Perimeter
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}", 2 * Math.PI * r);

        }
    }
}

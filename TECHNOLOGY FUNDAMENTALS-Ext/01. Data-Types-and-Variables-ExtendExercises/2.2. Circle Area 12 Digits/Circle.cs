using System;
//Write program to enter a radius r (real number) and print the area of the circle with exactly 12 digits after the decimal point. Use data type of enough precision to hold the results.
namespace _2._2.Circle_Area_12_Digits
{
    class Circle
    {
        static void Main()
        {

            double r = double.Parse(Console.ReadLine());
            double result = r * r * Math.PI;
            Console.WriteLine("{0:f12}", result);
        }
    }
}

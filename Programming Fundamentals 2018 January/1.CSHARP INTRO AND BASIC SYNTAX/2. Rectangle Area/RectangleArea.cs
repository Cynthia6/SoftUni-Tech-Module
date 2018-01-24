using System;
//Write a program, which calculates a rectangle’s area, based on its width and height. The width and height come as
//floating point numbers on the console, formatted to the 2 nd character after the decimal point.

namespace _2.Rectangle_Area
{
    class RectangleArea
    {
        static void Main()
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float result = width * height;
            Console.WriteLine($"{result:F2}");
        }
    }
}

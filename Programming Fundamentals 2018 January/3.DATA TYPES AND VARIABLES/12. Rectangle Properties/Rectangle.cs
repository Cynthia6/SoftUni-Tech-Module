using System;
//Create a program to calculate rectangle’s perimeter, area and diagonal by given its width and height.

namespace _12.Rectangle_Properties
{
    class Rectangle
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);
            Console.WriteLine(string.Join("\n", perimeter, area, diagonal));
        }
    }
}

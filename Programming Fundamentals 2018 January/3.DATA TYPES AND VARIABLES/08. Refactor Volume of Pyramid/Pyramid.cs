using System;
////You are given a working code that finds the volume of a pyramid.However, you should consider that the variables exceed their optimum span and have improper naming.
//Also, search for variables that have multiple purpose.

namespace _08.Refactor_Volume_of_Pyramid
{
    class Pyramid
    {
        static void Main()
        {
            double length, width, heigth = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            heigth = (length * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", heigth);
        }
    }
}

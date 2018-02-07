using System;
//Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and
//circle.
//On the first line you will get the figure type.Next you will get parameters for the chosen figure, each on a different line:
// Triangle - side and height
// Square - side
// Rectangle - width and height
// Circle - radius
//The output should be rounded to the second digit after the decimal point:

namespace _11._0_Geometry_Calculator
{
    class Calculator
    {
        static void Main()
        {
            string figureType = Console.ReadLine().ToLower();
            switch (figureType)
            {
                case "triangle":
                    double b = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintTriangleArea(b, h));
                    break;
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintSquareArea(a));
                    break;
                case "rectangle":
                    double w = double.Parse(Console.ReadLine());
                    double hRec = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintRectangleArea(w, hRec));
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintCircleArea(r));
                    break;
            }
        }
        static double PrintTriangleArea(double b, double h)
        {
            return (b * h) / 2;
        }
        static double PrintSquareArea(double a)
        {
            return a * a;
        }
        static double PrintRectangleArea(double w, double hRec)
        {
            return w * hRec;
        }
        static double PrintCircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
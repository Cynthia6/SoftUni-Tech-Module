using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a method that calculates and returns the area of a triangle by given base and height
namespace _05.CalculateTriangleArea
{
    class Triangle
    {
        public static double AreaTriangle(double a, double b)
        {
            return a * b / 2;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = AreaTriangle(width, height);
            Console.WriteLine(area);
        }
    }
}

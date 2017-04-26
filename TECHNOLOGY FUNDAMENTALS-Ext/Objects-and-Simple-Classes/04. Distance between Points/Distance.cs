using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. 
//Write a program to read two points (given as two integers) and print the Euclidean distance between them.
namespace _04.Distance_between_Points
{
    public class Distance
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }
        public static double CalcDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
        public static Point ReadPoint()
        {
            var pointCoordinates = Console.ReadLine()
               .Split(' ')
               .Select(double.Parse)
               .ToArray();
            return new Point
            {
                X = pointCoordinates[0],
                Y = pointCoordinates[1]
            };
        }
    }

}
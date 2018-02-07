using System;
//You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2. Create a method
//that prints the point that is closest to the center of the coordinate system(0, 0) in the format(X, Y). If the points are
//on a same distance from the center, print only the first one.

namespace _8.Center_Point
{
    class Point
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceFirstPoint = Distance(x1, y1);
            double disttanceSecondPoint = Distance(x2, y2);
            if (distanceFirstPoint < disttanceSecondPoint)
                Console.WriteLine($"({x1}, {y1})");
            else Console.WriteLine($"({x2}, {y2})");
        }

        public static double Distance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}
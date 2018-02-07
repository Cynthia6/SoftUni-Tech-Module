using System;
//Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area of a
//cube(http://www.mathopenref.com/cube.html) by a given side. On the first line you will get the side of the cube.
//On the second line is given the parameter (face, space, volume or area).

namespace _10._0_Cube_Properties
{
    class Cube
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = (Console.ReadLine());

            if (parameter == "face")
            {
                Console.WriteLine("{0:F2}", FindFaceDiagonals(side));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:F2}", FindSpaceDiagonals(side));
            }
            if (parameter == "volume")
            {
                Console.WriteLine("{0:F2}", FindVolume(side));
            }
            if (parameter == "area")
            {
                Console.WriteLine("{0:F2}", FindSurfaceArea(side));
            }


        }

        static double FindFaceDiagonals(double side)
        {
            double result = Math.Sqrt(2 * (side * side));
            return result;
        }
        static double FindSpaceDiagonals(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }
        static double FindVolume(double side)
        {
            double result = side * side * side;
            return result;
        }
        static double FindSurfaceArea(double side)
        {
            double result = 6 * (side * side);
            return result;
        }
    }
}
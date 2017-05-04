using System;

namespace _05.Distance_of_the_Stars
{
    // In physics, there are some well-known relative distances in Space:
    //•	The distance from Earth to its nearest star – Proxima Centauri: ~4.22 ly(light years)
    //•	The distance to the center of our galaxy – the Milky Way: ~26 000 ly
    //•	The diameter of the Milky Way: ~100 000 ly
    //•	The distance from Earth to the edge of the observable universe: ~46 500 000 000 ly
    //Write a program to calculate the aforementioned distances in kilometers.
    //Print the result using scientific notation with 2 points decimal precision
    //Assume that 1 light year == 9 450 000 000 000 km.

    public class Stars
    {
        public static void Main()
        {
            decimal proxima = 4.22m * 9450000000000m;
            decimal milkyWay = 26000M * 9450000000000m;
            decimal radiusMilkyWay = 100000M * 9450000000000m;
            decimal distanceEarth = 46500000000M * 9450000000000M;

            Console.WriteLine(proxima.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(radiusMilkyWay.ToString("e2"));
            Console.WriteLine(distanceEarth.ToString("e2"));

        }
    }
}

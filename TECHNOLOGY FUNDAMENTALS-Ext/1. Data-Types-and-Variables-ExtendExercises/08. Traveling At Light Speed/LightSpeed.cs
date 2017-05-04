using System;

namespace _08.Traveling_At_Light_Speed
{
    // Create a program that finds for how many weeks, days, hours, minutes and seconds can an object fly at light speed
    //Assume that 1 light year == 9 450 000 000 000 km.
    //Assume that the speed of light == 300 000 km / second.
    //Input
    //•	On first line you receive – the light years to convert
    //      Output
    //Every number in the output should be formatted to 0 digits after the floating point
    //•	On first line – time in weeks
    //•	On second line – time in days
    //•	On third line – time in hours
    //•	On fourth line – time in minutes
    //•	On fifth line – time in seconds



    public class LightSpeed
    {
        public static void Main()
        {

            decimal ly = decimal.Parse(Console.ReadLine());
            decimal lyInKm = 9450000000000;
            decimal lSpeedSec = 300000;
            decimal kilometers = 9450000000000 * ly;
            decimal Seconds = kilometers/300000;

            decimal Minutes = Seconds / 60;
            Seconds %= 60;
            decimal Hours = Minutes/60;
            Minutes %= 60;
            decimal day = Hours/24;
            Hours %= 24;
            decimal weeks = day/7;
            day %= 7;
                       
            Console.WriteLine("{0} weeks", Math.Floor(weeks));
            Console.WriteLine("{0} days", Math.Floor(day));
            Console.WriteLine("{0} hours", Math.Floor(Hours));
            Console.WriteLine("{0} minutes", Math.Floor(Minutes));
            Console.WriteLine("{0} seconds", Math.Floor(Seconds));
        }
    }
}

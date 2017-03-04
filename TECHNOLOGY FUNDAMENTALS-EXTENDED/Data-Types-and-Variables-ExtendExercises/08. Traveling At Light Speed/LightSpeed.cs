using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    class LightSpeed
    {
        static void Main(string[] args)
        {

            decimal ly = decimal.Parse(Console.ReadLine());
            decimal lyInKm = 9450000000000;
            decimal lSpeedSec = 300000;
            decimal total = (lyInKm / lSpeedSec) * ly;
            decimal weeks = total / 60 / 60 / 24 / 7;
            decimal day = total / 60 / 60 / 24 % 7;
            decimal Hours = total / 60 / 60 % 24;
            decimal Minutes = total / 60 % 60;
            decimal Seconds = total % 60;
            Console.WriteLine("{0} weeks", Math.Floor(weeks));
            Console.WriteLine("{0} days", Math.Floor(day));
            Console.WriteLine("{0} hours", Math.Floor(Hours));
            Console.WriteLine("{0} minutes", Math.Floor(Minutes));
            Console.WriteLine("{0} seconds", Math.Floor(Seconds));
        }
    }
}

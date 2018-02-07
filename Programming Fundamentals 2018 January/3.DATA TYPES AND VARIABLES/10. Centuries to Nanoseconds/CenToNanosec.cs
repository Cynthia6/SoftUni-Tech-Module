using System;
//Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.

namespace _10.Centuries_to_Nanoseconds
{
    class CenToNanosec
    {
        static void Main()
        {
            int cen = int.Parse(Console.ReadLine());

            int year = cen * 100;
            int days = (int)(365.2422m * year);
            decimal hours = Math.Round(days * 24m);
            decimal minutes = Math.Round(hours * 60m);
            decimal seconds = Math.Round(minutes * 60);
            decimal mili = Math.Round(seconds * 1000m);
            decimal micro = Math.Round(mili * 1000m);
            decimal nano = Math.Round(micro * 1000m);
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                cen, year, days, hours, minutes, seconds, mili, micro, nano);
        }
    }
}

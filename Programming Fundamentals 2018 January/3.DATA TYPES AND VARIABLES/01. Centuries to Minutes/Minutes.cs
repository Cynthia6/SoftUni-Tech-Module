using System;
//Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.

namespace _01.Centuries_to_Minutes
{
    class Minutes
    {
        static void Main()
        {
            Console.WriteLine("Centuries = ");
            int cen = int.Parse(Console.ReadLine());
            int years = cen * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", cen, years, days, hours, minutes);
        }
    }
}

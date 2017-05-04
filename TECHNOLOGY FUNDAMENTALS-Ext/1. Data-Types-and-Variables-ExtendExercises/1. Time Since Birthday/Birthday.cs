using System;

namespace _1.Time_Since_Birthday
{
    //Write program to enter an integer number of years and convert it to days, hours and minutes.
    public class Birthday
    {
        public static void Main()
        {
            byte years = byte.Parse(Console.ReadLine());

            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }

    
    }
}

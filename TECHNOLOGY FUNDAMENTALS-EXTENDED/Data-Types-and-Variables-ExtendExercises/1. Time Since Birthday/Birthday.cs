using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Time_Since_Birthday
{
    //Write program to enter an integer number of years and convert it to days, hours and minutes.
    class Birthday
    {
        static void Main(string[] args)
        {
            byte years = byte.Parse(Console.ReadLine());

            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }

    
    }
}

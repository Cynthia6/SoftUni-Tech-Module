using System;
//NB: You cannot solve this Problem with JAVA without using additional logic for the rounding.
//Create a program to ask the user for a distance(in meters) and the time taken(as three numbers: hours, minutes,
//seconds), and print the speed, in meters per second, kilometers per hour and miles per hour.
//Assume 1 mile = 1609 meters.
namespace _11.Convert_Speed_Units
{
    class SpeedUnits
    {
        static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = seconds + minutes * 60 + hours * 3600;

            float mPerS = (float)distance / time;
            float kmPerH = ((float)distance / 1000) / ((float)time / 3600);
            float mPerH = ((float)distance / 1609) / ((float)time / 3600);

            Console.WriteLine($"{mPerS:0.######}");
            Console.WriteLine($"{kmPerH:0.######}");
            Console.WriteLine($"{mPerH:0.######}");
        }
    }
}

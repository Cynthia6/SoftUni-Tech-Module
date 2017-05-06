using System;
using System.Linq;
//You are an airplane pilot, trying to maneuver your airplane to safety from an unknown danger.
//An array holds a sequence of up / down commands and numbers.Its first element always holds the initial altitude.The command up increases the altitude by the next number,
    //while the command down decreases the altitude by the next number.
//If at any point the altitude becomes either zero or negative, print “crashed” and end the program. If by the end, the altitude is positive, however, 
//print “got through safely.current altitude: { altitude}m”.

namespace _9.Altitude
{
    public class Altitude
    {
        public static void Main()
        {
            string[] altitudeChanges = Console.ReadLine().Split(' ').ToArray();
            double currentAltitude = double.Parse(altitudeChanges[0]);
            for (int i = 1; i < altitudeChanges.Length; i++)
            {
                if (altitudeChanges[i].Contains("up"))
                {
                    currentAltitude += double.Parse(altitudeChanges[i+1]);
                }
                else if (altitudeChanges[i].Contains("down"))
                {
                    currentAltitude -= double.Parse(altitudeChanges[i+1]);
                    if (currentAltitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }
            if (currentAltitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", currentAltitude);
            }
        }
    }
}
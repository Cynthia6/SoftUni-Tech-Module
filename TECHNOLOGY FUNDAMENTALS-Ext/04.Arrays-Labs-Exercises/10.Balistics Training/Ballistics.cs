using System;
using System.Linq;

namespace _10.Balistics_Training
{
    public class Ballistics
    {
        public static void Main()
        {
            var cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sequence = Console.ReadLine().Split();
            var result = new int[2];

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == "up")
                {
                    result[1] += int.Parse(sequence[i+1]);
                }
                else if (sequence[i] == "down")
                {
                    result[1] -= int.Parse(sequence[i+1]);
                }
                else if (sequence[i] == "left")
                {
                    result[0] -= int.Parse(sequence[i+1]);
                }
                else if (sequence[i] == "right")
                {
                    result[0] += int.Parse(sequence[i+1]);
                }
            }

            if (cordinates[0] == result[0] && cordinates[1] == result[1])
            {
                Console.WriteLine("firing at [{0}, {1}]", result[0], result[1]);
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("firing at [{0}, {1}]", result[0], result[1]);
                Console.WriteLine("better luck next time...");
            }

        }
    }
}
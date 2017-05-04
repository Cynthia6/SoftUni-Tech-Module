using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._4_Extremums
{
    public class Extremums
    {
        public static void Main()
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine().ToLower();

            List<int> extremums = inputList.Select(x => FindExtremums(x, command)).ToList();

            Console.WriteLine(string.Join(", ", extremums));
            Console.WriteLine(extremums.Sum());
        }

        private static int FindExtremums(int x, string command)
        {
            int extremum = x;
            int digits = GetDigits(x);

            for (int i = 0; i < digits; i++)
            {
                int rotated = int.Parse(RotateNumber(x, i));

                if (command == "min" && rotated < extremum)
                {
                    extremum = rotated;
                }

                if (command == "max" && rotated > extremum)
                {
                    extremum = rotated;
                }
            }
            return extremum;
        }

        private static string RotateNumber(int x, int rotations)
        {
            List<char> digits = x.ToString().ToList();
            for (int i = 0; i < rotations; i++)
            {
                char temp = digits[0];
                digits.RemoveAt(0);
                digits.Add(temp);
            }

            return string.Join("", digits);
        }

        private static int GetDigits(int x)
        {
            int digits = x.ToString().Length;
            return digits;
        }
    }
}
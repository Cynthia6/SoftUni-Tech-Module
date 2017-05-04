using System;
using System.Text.RegularExpressions;

namespace _4.Happiness_Index
{
    public class HappyIndex
    {
        public static void Main()
        {
            Regex happyPattern = new Regex(@"(:\)|:D|;\)|:\*|:\]|;\]|:\}|;\}|\(:|\*:|c:|\[:|\[;)");
            Regex sadPattern = new Regex(@"(:\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];)");

            string input = Console.ReadLine();

            int happyCount = happyPattern.Matches(input).Count;
            int sadCount = sadPattern.Matches(input).Count;

            double happyIndex = happyCount / (double)sadCount;
            var status = string.Empty;

            if (happyIndex >= 2)
            {
                status = ":D";
            }
            else if (happyIndex > 1)
            {
                status = ":)";
            }
            else if (happyIndex == 1)
            {
                status = ":|";
            }
            else if (happyIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {happyIndex:F2} {status}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
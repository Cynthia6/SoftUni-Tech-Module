using System;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    public class MatchNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\s?\+359(\s+|-)\d{1}\1\d{3}\1\d{4}\b";
            while (input != "end")
            {
                var regex = new Regex(pattern);
                var result = regex.IsMatch(input);
                if (result) Console.WriteLine(input);
                input = Console.ReadLine();


            }

        }
    }
}

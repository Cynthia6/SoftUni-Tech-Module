using System;
using System.Text.RegularExpressions;

namespace _01.Match_full_name
{
    public class MatchName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"[A-Z][a-z]+\s[A-Z][a-z]+";
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

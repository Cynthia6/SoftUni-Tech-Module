using System;
using System.Text.RegularExpressions;

namespace _03.Replace_a_tag
{
    public class Replace
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"<a.+?href=(.+?)>(.+?)<\/a>";
            var regex = new Regex(pattern);
            var replacement = @"[URL href=$1]$2[/URL]";


            while (input != "end")
            {

                var result = Regex.Replace(input, pattern, replacement);
                Console.WriteLine(result);
                input = Console.ReadLine();

            }
            
        }
    }
}
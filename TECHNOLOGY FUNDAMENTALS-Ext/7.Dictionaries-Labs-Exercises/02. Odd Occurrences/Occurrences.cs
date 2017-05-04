using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given sequence of words all elements that present in it odd number of times (case-insensitive).
//•	Words are given in a single line, space separated.
//•	Print the result elements in lowercase, in their order of appearance.

namespace _02.Odd_Occurrences
{
    public class Occurrences
    {
        public static void Main()
        {
            var nums = Console.ReadLine().ToLower().Split(' ').ToArray();
            var odds = new Dictionary<string, int>();
            foreach (var word in nums)
            {
                if(!odds.ContainsKey(word))
                {
                    odds[word] = 0;
                }
                odds[word]++;
            }
            var oddcounts = new List<string>();
            foreach (var kvp in odds)
            {
                if(kvp.Value%2!=0)
                {
                    oddcounts.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddcounts));
        }
    }
}

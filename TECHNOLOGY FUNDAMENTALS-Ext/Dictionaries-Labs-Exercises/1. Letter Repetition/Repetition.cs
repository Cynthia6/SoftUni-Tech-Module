using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will be given a single string, containing random ASCII character. Your task is to print every character, and how many times it has been used in the string.
namespace _1.Letter_Repetition
{
    public class Repetition
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var result = new Dictionary<char, int>();
            foreach (var word in input)
            {
                if(!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a list of real numbers and print them in ascending order along with their number of occurrences.
namespace _01.Count_Real_Numbers
{
    public class RealNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().ToLower().Split().Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();
           
            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;

                }
                counts[num]++;
            }
            foreach (var kvp in counts)
            {
           //     var times = kvp.Value == 1 ? "time" : "times";
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.
namespace _07.Count_Numbers
{
    class Count
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] countExisting = new int[1000];

            foreach (var num in numbers)
            {
                countExisting[num]++;
            }

            for (int i = 0; i < countExisting.Length; i++)
            {
                if (countExisting[i] > 0)
                {
                    Console.WriteLine($"{i} -> {countExisting[i]}");
                }
            }
        }
    }
}

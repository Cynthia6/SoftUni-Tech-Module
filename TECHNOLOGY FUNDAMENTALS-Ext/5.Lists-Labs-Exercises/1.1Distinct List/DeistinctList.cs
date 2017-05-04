using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will be given a list of integers on the first line of the input (space-separated). Remove all repeating elements from the list.
namespace _1._1Distinct_List
{
    public class DeistinctList
    {
        public static void Main()
        {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int r = 1 + i; r < numbers.Count; r++)
                {
                    if (numbers[i] == numbers[r])
                    {
                        numbers.RemoveAt(r);
                        r--;
                    }
                }
            }
            //foreach (var number in numbers.Distinct()) Exclude duplicates
            //    {
            //        result.Add(number);
            //    }

            Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
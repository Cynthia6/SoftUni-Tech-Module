using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a list of integers on the first line of the console. After that, sort the array, using the Insertion Sort algorithm.
namespace _05.SortArrayUsingInsertion
{
    public class Insertion
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    int current = numbers[j - 1];
                    int next = numbers[j];

                    if (next < current)
                    {
                        numbers[j] = current;
                        numbers[j - 1] = next;
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
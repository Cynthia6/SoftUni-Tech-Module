using System;
using System.Linq;
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
                    if(numbers[j] < numbers[j-1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
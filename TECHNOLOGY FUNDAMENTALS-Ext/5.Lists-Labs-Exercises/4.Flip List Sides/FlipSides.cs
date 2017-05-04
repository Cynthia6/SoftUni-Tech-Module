using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will receive an integer list on the first line of the input (space-separated). 
//Leave the first, middle and last elements as they are. For every other element, exchange it with its opposite indexed element
// (list[1]  list[length-2] and so on…). After that, print the list on the console (space-separated).
namespace _4.Flip_List_Sides
{
    public class FlipSides
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < (numbers.Count / 2) - 1; i++)
            {
                string prev = numbers[i + 1];
                numbers[i + 1] = numbers[numbers.Count - 2 - i];
                numbers[numbers.Count - 2 - i] = prev;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
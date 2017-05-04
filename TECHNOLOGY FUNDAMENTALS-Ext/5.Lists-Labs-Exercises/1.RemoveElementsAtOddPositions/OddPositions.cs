using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program which reads a list of space-separated strings and 
//removes the elements at positions [1…3…5…7…etc.]. After that, print the elements with no delimiter. Note that positions are counted from 1.
namespace _1.RemoveElementsAtOddPositions
{
    public class OddPositions
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < nums.Count; i++)//+=2
            {
                nums.RemoveAt(i);
                //i--;
            }
            Console.WriteLine(string.Join("", nums));

        }
    }
}

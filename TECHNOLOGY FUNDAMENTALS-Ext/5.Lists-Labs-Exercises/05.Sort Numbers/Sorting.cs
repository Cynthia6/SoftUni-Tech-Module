using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.
namespace _05.Sort_Numbers
{
    public class Sorting
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));

        }
    }
}

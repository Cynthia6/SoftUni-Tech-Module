using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read an array of integers and find out if all the elements in the array are the same.
namespace _6.EqualSequenceofElements
{
    class EqualSequence
    {
        static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int count = 0;
            for (int i = 0; i < numsArr.Length - 1; i++)
            {
                if (numsArr[i] == numsArr[i + 1]) count++;
                //  if (numbers[i] != numbers[i - 1])

            }
            if (numsArr[numsArr.Length - 1] == numsArr[numsArr.Length - 2]) count++;
            if (count == numsArr.Length) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

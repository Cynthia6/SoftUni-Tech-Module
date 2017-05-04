using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read an array of integers and find out if it is an increasing sequence. Print Yes if it does and No if it doesn’t.
namespace _5.IncreasingSequenceofElements
{
    public class IncreasingSequence
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
           
            int count = 0;
            for (int i = 0; i < numsArr.Length-1; i++)
            {
                if (numsArr[i] < numsArr[i+1]) count++;

            }
            if (numsArr[numsArr.Length - 1] > numsArr[numsArr.Length-2]) count++;
            if (count == numsArr.Length) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read an integer N and on the next N lines read an array of integers. Then, find its largest element.
namespace _1.Largest_Element_in_Array
{
    public class Largest
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numsArr = new int[n];
            int largest = int.MinValue;
            for (int i = 0; i < numsArr.Length; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > largest) largest = currentNum;
            }
            Console.WriteLine(largest);
        }
    }
}

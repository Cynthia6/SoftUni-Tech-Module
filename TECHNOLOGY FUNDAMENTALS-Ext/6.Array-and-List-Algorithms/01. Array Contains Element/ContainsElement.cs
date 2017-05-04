using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a list of integers on the first line of the console and an integer N from the second line of the console and print whether the element is contained in the array. 
//If it is, print “yes”, otherwise print “no”.
namespace _01.Array_Contains_Element
{
    public class ContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            bool found = false;

            foreach (var number in numbers)
            {
                if (number == num)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
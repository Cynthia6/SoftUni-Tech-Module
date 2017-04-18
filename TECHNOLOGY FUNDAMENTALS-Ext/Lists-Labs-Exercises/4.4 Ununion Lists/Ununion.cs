using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will be given a sequence of integers, separated by a space. This is the primal list. Then you will receive an integer N. 
//On the next N lines, you will receive sequences of integers. Your task is to add all elements that the primal list does not 
//contain from the current sequence to the primal list and then remove from the primal list, all elements which are
// contained in the current sequence of integers. If there are several occurrences, remove all occurrences you find.
//After you are done receiving lists and manipulating the primal list, sort the primal list and print it.

namespace _4._4_Ununion_Lists
{
    public class Ununion
    {
        public static void Main()
        {
            var primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                foreach (var item in currentList)
                {
                    if (!primal.Contains(item)) primal.Add(item);

                    else
                    {
                        primal.RemoveAll(x => x == item);
                    }
                }
            }
            primal.Sort();
            Console.WriteLine(string.Join(" ", primal));
        }
    }
}




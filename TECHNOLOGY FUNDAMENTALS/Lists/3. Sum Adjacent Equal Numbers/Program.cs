using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var items = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < items.Count; i++)
            {
                if (items[i-1]==items[i])
                {
                    items[i - 1] += items[i];
                    items.RemoveAt(i);
                    i =i-2;
                    if (i < 0) i = 0;
                    // only i=0 works too
                }
            }
            Console.WriteLine(string.Join(" ",items ));

        }
    }
}

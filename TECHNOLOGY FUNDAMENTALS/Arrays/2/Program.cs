using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var reverse = new int[n];
            for (int i = 0; i < reverse.Length; i++)
            {
                int currentnumber= int.Parse(Console.ReadLine());
                reverse[i] = currentnumber;

            }
            for (int i = reverse.Length-1; i >= 0; i--)
            {
                Console.WriteLine(reverse[i]);
            }
        }
    }
}

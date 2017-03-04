using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Trinagle(n);

        }
        public static void PrintLine(int rows)
        {
            for (int col = 1; col <= rows; col++)
            {
                Console.Write("{0} ", col);
            }
            Console.WriteLine();
        }
        public static void Trinagle(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                PrintLine(rows);
            }
            for (int rows = n - 1; rows >= 1; rows--)
            {
                PrintLine(rows);
            }
        }
    }
}

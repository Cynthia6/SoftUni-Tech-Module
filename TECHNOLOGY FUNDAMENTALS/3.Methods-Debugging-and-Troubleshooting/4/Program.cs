using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =
int.Parse(Console.ReadLine());
            beginEnd(n);
            Middle(n);
            beginEnd(n);


        }

            public static void beginEnd (int n)
        {
            Console.WriteLine(new string ('-', n*2));
        }

        public static void Middle(int n)
        {
            for (int i = 2; i <= n-1; i++)
            {
                
                Console.Write("-");
                for (int i2 = 1; i2 <= n - 1; i2++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
        
    }
}

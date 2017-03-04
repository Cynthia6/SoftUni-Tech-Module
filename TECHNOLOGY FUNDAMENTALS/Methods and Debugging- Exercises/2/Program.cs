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
            int a =
int.Parse(Console.ReadLine());

            int b =
int.Parse(Console.ReadLine());

            int c =
int.Parse(Console.ReadLine());
       int temp =     GetMax1(a, b);
            int maxnumber = GetMax1(temp, c);
            Console.WriteLine(maxnumber);
                

        }
            public static int GetMax1(int a, int b)
        {
            if (a > b) return a;
            else return b;
        
        }
      
    }
}

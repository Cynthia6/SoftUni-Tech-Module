using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class ASCII
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {

             int num =   int.Parse(Console.ReadLine());
             result += (char)num;
                
            }
            Console.WriteLine(result);
        }
    }
}

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
            double ppl = double.Parse(Console.ReadLine());
            double courses = double.Parse(Console.ReadLine());
            double result = ppl / courses;
             //  Console.WriteLine( Math.Ceiling(ppl/courses) );
            if (ppl % courses != 0) result = result + 1;
            Console.WriteLine((int)result);
        }
    }
}

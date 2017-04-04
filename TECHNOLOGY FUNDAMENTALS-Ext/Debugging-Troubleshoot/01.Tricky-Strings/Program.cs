using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                
                var currentString = string.Empty;
                currentString = Console.ReadLine();
                result += currentString;
                if (i != numberOfStrings) result += delimiter;
                
            }
            Console.WriteLine(result);
        }
    }
}

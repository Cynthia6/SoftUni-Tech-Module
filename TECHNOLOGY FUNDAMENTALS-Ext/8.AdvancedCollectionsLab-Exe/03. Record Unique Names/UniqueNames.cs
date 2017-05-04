using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program, which will take a list of names and print only the unique names in the list.
namespace _03.Record_Unique_Names
{
    public class UniqueNames
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
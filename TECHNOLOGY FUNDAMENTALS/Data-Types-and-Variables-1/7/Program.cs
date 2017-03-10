using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
              string firstName =  Console.ReadLine();
              string lastName = Console.ReadLine();
              string ageS = Console.ReadLine();
              int age = int.Parse (ageS);


            Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");

        }
    }
}

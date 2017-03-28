using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
namespace _1.Hello__Name_
{
    class Name
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            Console.WriteLine(HelloName(name));
        }
        public static string HelloName(string a)
        {
            string result = $"Hello, {a}!";
            return result;
        }
    }
}

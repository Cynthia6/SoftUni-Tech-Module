using System;
//Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
namespace _1.Hello__Name_
{
    public class Name
    {
        public static void Main()
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

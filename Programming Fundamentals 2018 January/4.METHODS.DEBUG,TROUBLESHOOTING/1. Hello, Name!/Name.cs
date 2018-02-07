using System;
//Write a method that receives a name as parameter and prints on the console. “Hello, &lt;name&gt;!”

namespace _1.Hello__Name_
{
    class Name
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}

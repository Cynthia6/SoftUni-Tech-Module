using System;
//Write a program, which greets the user by their name, which it reads from the console.
namespace _01.Greeting
{
    class Greeting
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

        }
    }
}

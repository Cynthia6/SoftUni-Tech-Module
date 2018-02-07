using System;
//Write a program that reads a string, converts it to Boolean variable and prints “Yes” if the variable is true and “No” if the variable is false.

namespace _5.Boolean_Variable
{
    class Boolean
    {
        static void Main()
        {
            string word = Console.ReadLine();

            if (Convert.ToBoolean(word) == true)
                Console.WriteLine("Yes");
            else if (Convert.ToBoolean(word) == false)
                Console.WriteLine("No");


        }
    }
}
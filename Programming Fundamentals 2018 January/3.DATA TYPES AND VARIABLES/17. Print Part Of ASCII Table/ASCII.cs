using System;
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a
//program that prints part of the ASCII table of characters at the console.On the first line of input you will receive
//the char index you should start with and on the second line - the index of the last character you should print.

namespace _17.Print_Part_Of_ASCII_Table
{
    class ASCII
    {
        static void Main()
        {
            int indexStart = int.Parse(Console.ReadLine());
            int indexEnd = int.Parse(Console.ReadLine());

            for (int i = indexStart; i <= indexEnd; i++)
                Console.Write("{0} ", (char)i);
        }
    }
}

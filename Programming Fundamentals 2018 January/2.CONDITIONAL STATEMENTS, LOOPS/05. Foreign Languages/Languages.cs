using System;
//Write a program, which prints the language, that a given country speaks. You can receive only the following
//combinations: English is spoken in England and USA; Spanish is spoken in Spain, Argentina and Mexico; for the
//others, we should print &quot;unknown&quot;.

namespace _05.Foreign_Languages
{
    class Languages
    {
        static void Main()
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
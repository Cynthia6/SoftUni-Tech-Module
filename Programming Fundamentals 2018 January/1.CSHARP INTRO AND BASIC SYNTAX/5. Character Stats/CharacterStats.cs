using System;
//Write a program, which displays information about a video game character. You will receive their name, current
//health, maximum health, current energy and maximum energy on separate lines.The current values will always be
//valid(equal or lower than their respective max values). Print them in the format as per the examples.
namespace _5.Character_Stats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: ");
            Console.WriteLine("|" + new string('|', health) + new string('.', healthMax - health) + "|");
            Console.Write($"Energy: ");
            Console.WriteLine("|" + new string('|', energy) + new string('.', energyMax - energy) + "|");
        }
    }
}

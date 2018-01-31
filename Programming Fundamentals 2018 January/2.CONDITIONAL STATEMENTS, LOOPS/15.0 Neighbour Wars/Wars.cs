using System;
//Gosho and Pesho are neighbours, but they don’t like each other very much. They don’t like violence as well, so they
//decided they need a save environment where they can fight each other.They hired you to write a program, which
//calculates who would win the fight.
//Gosho and Pesho have their own signature attacks – Gosho attacks with “Thunderous fist” on every even turn of
//the game and Pesho attacks with “Roundhouse kick” on every odd turn. You will receive how much damage these
//attacks do from the console.
//Both players start with 100 Health points. On every third turn Pesho and Gosho restore 10 Health Points. Health
//points are restored after the attack is made.
//When one of the player’s health is below or equal to zero you should stop any other further operations and print
//who the winner is, how much health points he has and in which turn he won. Since Mike Tyson is the judge of the
//match, the winning round is always printed with “th” in the end.

namespace _15._0_Neighbour_Wars
{
    class Wars
    {
        static void Main()
        {
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int i = 1;
            int counter = 0;
            while (peshoHealth > 0  && goshoHealth > 0)
            {
                counter++;
                if (i % 2 != 0)
                {
                    goshoHealth -= peshoDMG;
                    if (goshoHealth <= 0) break;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else if (i % 2 == 0)
                {
                    peshoHealth -= goshoDMG;
                    if (peshoHealth <= 0) break;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                    
                if (counter == 3)
                {
                    counter = 0;
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                i++;
                      
            }

            if (peshoHealth >= goshoHealth) Console.WriteLine($"Pesho won in {i}th round.");
            else Console.WriteLine($"Gosho won in {i}th round.");


        }
    }
}

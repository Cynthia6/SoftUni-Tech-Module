using System;
//Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the
//system.For every given ingredient, you should write: “Adding ingredient { name of the ingredient }.”. When you
//receive the command “Bake!” from the console you should stop the program and write “Preparing cake with
//{number of given ingredients} ingredients.”.
namespace _7.Cake_Ingredients
{
    class Cake
    {
        static void Main()
        {
            string ingredientName = Console.ReadLine();
            int ingredientNum = 0;
            do
            {
                Console.WriteLine($"Adding ingredient {ingredientName}.");
                ingredientNum++;
                ingredientName = Console.ReadLine();
            } while (ingredientName != "Bake!");

            //while ( ingredientName != "Bake!")
            //{
            //    Console.WriteLine($"Adding ingredient {ingredientName}.");
            //    ingredientNum++;
            //    ingredientName = Console.ReadLine();
            //}

            Console.WriteLine($"Preparing cake with {ingredientNum} ingredients.");
        }
    }
}

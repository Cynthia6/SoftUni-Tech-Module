using System;
//You have to write a program, which counts the calories, which can be found in your pizza recipe. In your recipe,
//there are only four ingredients – cheese, tomato sauce, salami and pepper.Each ingredient contains a fixed
//amount of calories:
// Cheese – 500 calories
// Tomato sauce – 150 calories
// Salami – 600 calories
// Pepper – 50 calories
//If you receive one of these ingredients more than once, you should add the calories to the total amount again. You
//should not process any other ingredients.Ingredients are case-insensitive.

namespace _8.Calories_Counter
{
    class Calories
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int caloriesAmount = 0;
            for (int i = 0; i < num; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese") caloriesAmount += 500;
                else if (ingredient == "tomato sauce") caloriesAmount += 150;
                else if (ingredient == "salami") caloriesAmount += 600;
                else if (ingredient == "pepper") caloriesAmount += 50;
               
            }
            Console.WriteLine($"Total calories: {caloriesAmount}");
        }
    }
}

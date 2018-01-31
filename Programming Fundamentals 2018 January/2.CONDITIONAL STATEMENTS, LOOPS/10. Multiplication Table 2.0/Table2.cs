using System;
//Rewrite you program so it can receive the multiplier from the console. Print the table from the given multiplier to
//10. If the given multiplier is more than 10 - print only one row with the integer, the given multiplier and the
//product.See the examples below for more information.

namespace _10.Multiplication_Table_2._0
{
    class Table2
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
          
            do
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                multiplier++;                
            } while (multiplier <= 10);
        }
    }
}

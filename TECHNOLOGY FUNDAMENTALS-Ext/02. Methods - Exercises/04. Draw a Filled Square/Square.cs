using System;
//Draw at the console a filled square of size n like in the example:4
//--------
//-\/\/\/-
//-\/\/\/-
//--------

namespace _04.Draw_a_Filled_Square
{
    public class Square
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', n*2));
            for (int rows = 0; rows < n-2; rows++)
            {
                PrintLines(n);
            }
            Console.WriteLine(new string('-', n * 2));
        }
        public static void PrintLines(int n)
        {
            Console.Write("-");
            for (int lines = 0; lines <= n-2; lines++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
           // Console.WriteLine();
        }
    }
}

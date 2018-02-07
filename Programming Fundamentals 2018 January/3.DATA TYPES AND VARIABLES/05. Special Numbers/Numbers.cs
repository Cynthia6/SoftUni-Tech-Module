using System;
//A number is special when its sum of digits is 5, 7 or 11.
//Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not(True / False).


namespace _05.Special_Numbers
{
    class Numbers
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)

            {
                int sum = 0;
                int digits = i;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}

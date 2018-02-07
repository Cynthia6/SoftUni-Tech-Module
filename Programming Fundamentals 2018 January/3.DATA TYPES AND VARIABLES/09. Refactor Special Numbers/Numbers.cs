using System;
//You are given a working code that is a solution to Problem 5. Special Numbers. However, the variables are improperly named, declared before they are needed and some of them are used for 
//multiple things.Without using your previous solution, modify the code so that it is easy to read and understand.


namespace _09.Refactor_Special_Numbers
{
    class Numbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; int digits = 0; bool special = false;
            for (int i = 1; i <= n; i++)
            {
                digits = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digits, special);
                sum = 0;
                i = digits;
            }
        }
    }
}
